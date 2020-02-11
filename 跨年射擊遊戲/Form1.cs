using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 跨年射擊遊戲
{
    public partial class Form1 : Form
    {
        public int skill = 1;
        public static int playerX, playerY;
        public Random rd = new Random();
        public PictureBox player = new PictureBox();
        int monsteradd = 1000;
        int grand = 0;
        int monster = 0;
        string Lv;
        bool stop = false;
        bool spaceup = true;
        bool gameover = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if(e.KeyCode == Keys.F5)
            {
                Application.Restart();
            }
            if (gameover == true)
            {
                return;
            }
            if(!stop)
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    right.Enabled = true;
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    left.Enabled = true;
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    up.Enabled = true;
                }
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    down.Enabled = true;
                }
                if (spaceup == true)
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        spaceup = false;
                        shoop.Interval = 1;
                        shoop.Enabled = true;
                    }
                }
            }
            if (stop == false)
            {
                if (e.KeyCode == Keys.NumPad3|| e.KeyCode == Keys.D3)
                {
                    Clear();
                    label1.Text = "分數：1450";
                    Lv = "Lv3";
                    grand = 1450;
                    monster = 125;
                    Monstermove.Enabled = false;
                    Monsterbutton.Enabled = false;
                    AddMonster.Enabled = false;
                    buttonmove.Enabled = false;
                    right.Enabled = false;
                    left.Enabled = false;
                    up.Enabled = false;
                    down.Enabled = false;
                    Monstermove.Interval = 16;
                    AddMonster.Interval = 10;
                    BigMonsterMoveTimes = 3;
                    BigMonsterMoveRange = 45;
                    Lv = "Lv3";
                    LV.labtxt = "Lv3";
                    MonsterButtonRd = 88;
                    BigMonsterButtonRd = 65;
                    BigMonsterHP = 75;
                    bigcount = 0;
                    new LV().ShowDialog();
                    Monstermove.Enabled = true;
                    Monsterbutton.Enabled = true;
                    AddMonster.Enabled = true;
                    buttonmove.Enabled = true;
                    label2.Text = "";
                    skill=3;
                    for (int i = 0; i < skill; i++)
                    {
                        label2.Text += "ⓢ";
                    }
                }
                else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
                {
                    Clear();
                    label1.Text = "分數：600";
                    grand = 600;
                    monster = 50;
                    Monstermove.Enabled = false;
                    Monsterbutton.Enabled = false;
                    AddMonster.Enabled = false;
                    buttonmove.Enabled = false;
                    right.Enabled = false;
                    left.Enabled = false;
                    up.Enabled = false;
                    down.Enabled = false;
                    Monstermove.Interval = 20;
                    AddMonster.Interval = 250;
                    BigMonsterMoveTimes = 3;
                    BigMonsterMoveRange = 35;
                    Lv = "Lv2";
                    LV.labtxt = "Lv2";
                    MonsterButtonRd = 92;
                    BigMonsterButtonRd = 75;
                    BigMonsterHP = 50;
                    bigcount = 0;
                    new LV().ShowDialog();
                    Monstermove.Enabled = true;
                    Monsterbutton.Enabled = true;
                    AddMonster.Enabled = true;
                    buttonmove.Enabled = true;
                    label2.Text = "";
                    skill=2;
                    for (int i = 0; i < skill; i++)
                    {
                        label2.Text += "ⓢ";
                    }
                }
                else if(e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
                {
                    Clear();
                    label1.Text = "分數：0";
                    grand = 0;
                    monster = 0;
                    Monstermove.Enabled = false;
                    Monsterbutton.Enabled = false;
                    AddMonster.Enabled = false;
                    buttonmove.Enabled = false;
                    right.Enabled = false;
                    left.Enabled = false;
                    up.Enabled = false;
                    down.Enabled = false;
                    Monstermove.Interval = 20;
                    AddMonster.Interval = 500;
                    BigMonsterMoveTimes = 2;
                    BigMonsterMoveRange = 20;
                    Lv = "Lv1";
                    LV.labtxt = "Lv1";
                    MonsterButtonRd = 96;
                    BigMonsterButtonRd = 80;
                    BigMonsterHP = 35;
                    bigcount = 0;
                    new LV().ShowDialog();
                    Monstermove.Enabled = true;
                    Monsterbutton.Enabled = true;
                    AddMonster.Enabled = true;
                    buttonmove.Enabled = true;
                    label2.Text = "";
                    skill=1;
                    for (int i = 0; i < skill; i++)
                    {
                        label2.Text += "ⓢ";
                    }
                }
                else if(e.KeyCode == Keys.F)
                {
                    if(skill > 0)
                    {
                        Monstermove.Enabled = false;
                        Monsterbutton.Enabled = false;
                        AddMonster.Enabled = false;
                        buttonmove.Enabled = false;
                        skills.Enabled = true;
                        label2.Text = "";
                        skill--;
                        for (int i = 0; i < skill; i++)
                        {
                            label2.Text += "ⓢ";
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.P)
            {
                stoptimeP++;
                if (stoptimeP % 2 == 1)
                {
                    Monstermove.Enabled = false;
                    Monsterbutton.Enabled = false;
                    AddMonster.Enabled = false;
                    buttonmove.Enabled = false;
                    stop = true;
                }
                else
                {
                    stoptimeH  = 0;
                    stop = false;
                    Monstermove.Enabled = true;
                    Monsterbutton.Enabled = true;
                    AddMonster.Enabled = true;
                    buttonmove.Enabled = true;
                }
            }
            if(e.KeyCode == Keys.H)
            {
                stoptimeH++;
                stop = false;
                if (stoptimeH % 2 == 1)
                {
                    Monstermove.Enabled = false;
                    Monsterbutton.Enabled = false;
                    AddMonster.Enabled = false;
                    buttonmove.Enabled = false;
                }
                else
                {
                    stoptimeP = 0;
                    stop = false;
                    Monstermove.Enabled = true;
                    Monsterbutton.Enabled = true;
                    AddMonster.Enabled = true;
                    buttonmove.Enabled = true;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Lv = "Lv1";
            this.Size = new Size(800,750);
            this.StartPosition =   FormStartPosition.CenterParent;
            this.Location = new Point(this.Location.X/2 , this.Location.Y/2);
            player.Size = new Size(70, 70);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.Location = new Point((this.Size.Width / 2 - player.Size.Width / 2), this.Size.Height - 100);
            player.Image = Properties.Resources.小飛機;
            this.Controls.Add(player);
            playerX = this.Size.Width / 2 - player.Size.Width / 2;
            playerY = this.Size.Height - 100;
            label2.Location = new Point(5, this.Height- label2.Size.Height -20);
        }
        private void right_Tick(object sender, EventArgs e)
        {
            if (player.Location.X+player.Size.Width <= this.Width)
            {
                player.Location = new Point(player.Location.X + 7, player.Location.Y);
                playerX = player.Location.X;
            }
        }

        private void left_Tick(object sender, EventArgs e)
        {
            if (player.Location.X >= 0)
            {
                player.Location = new Point(player.Location.X - 7, player.Location.Y);
                playerX = player.Location.X;
            }
        }
        int stoptimeP = 0;
        int stoptimeH = 0;
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                spaceup = true;
                shoop.Enabled = false;
            }
            if (e.KeyCode == Keys.Right ||e.KeyCode == Keys.D)
            {
                right.Enabled = false;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left.Enabled = false ;
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                up.Enabled = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down.Enabled = false;
            }
        }

        private void buttonmove_Tick(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c.Tag == "Button")
                {
                    if (c.Location.Y <= 0)
                    {
                        c.Dispose();
                    }
                    else
                    {
                        c.Location = new Point(c.Location.X, c.Location.Y - 9);
                    }
                }
                else if (c.Tag == "MonsterButton")
                {
                    if (c.Location.X + c.Size.Width >= player.Location.X && c.Location.Y <= player.Location.Y + player.Size.Height && c.Location.X <= player.Location.X + player.Size.Width && c.Location.Y + c.Size.Height >= player.Location.Y)
                    {
                        c.Dispose();
                        player.Dispose();
                        Monstermove.Enabled = false;
                        Monsterbutton.Enabled = false;
                        AddMonster.Enabled = false;
                        buttonmove.Enabled = false;
                        right.Enabled = false;
                        left.Enabled = false;
                        up.Enabled = false;
                        down.Enabled = false;
                        gameover = true;
                        MessageBox.Show("遊戲結束，挑戰者失敗");
                        return;
                    }
                    if (c.Location.Y >= this.Height)
                    {
                        c.Dispose();
                    }
                    else
                    {
                        c.Location = new Point(c.Location.X, c.Location.Y + 4);
                    }
                }
            }
        }

        private void down_Tick(object sender, EventArgs e)
        {
            if(player.Location.Y+player.Size.Height <= this.Size.Height)
            {
                player.Location = new Point(player.Location.X, player.Location.Y + 5);
                playerY = player.Location.Y;
            }
        }

        private void up_Tick(object sender, EventArgs e)
        {
            if (player.Location.Y  >= 0)
            {
                player.Location = new Point(player.Location.X, player.Location.Y - 5);
                playerY = player.Location.Y;
            }
        }

        private void AddMonster_Tick(object sender, EventArgs e)
        {
            AddMonster.Interval = monsteradd;
            this.Controls.Add(new Monster(this.Width));
            monsteradd = rd.Next(500, 1500);
            monster++;
            if(monster == 50 && Lv == "Lv1")
            {
                AddMonster.Enabled = false;
            }
            else if(monster == 125 && Lv == "Lv2")
            {
                AddMonster.Enabled = false;
            }
            else if (monster == 200 && Lv == "Lv3")
            {
                AddMonster.Enabled = false;
            }
        }
        private void Monstermove_Tick(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c.Tag == "Monster")
                {
                    if (c.Location.X + c.Size.Width >=player.Location.X && c.Location.Y <= player.Location.Y + player.Size.Height && c.Location.X <= player.Location.X + player.Size.Width && c.Location.Y + c.Size.Height >= player.Location.Y)
                    {
                        c.Dispose();
                        player.Dispose();
                        Monstermove.Enabled = false;
                        Monsterbutton.Enabled = false;
                        AddMonster.Enabled = false;
                        buttonmove.Enabled = false;
                        right.Enabled = false;
                        left.Enabled = false;
                        up.Enabled = false;
                        down.Enabled = false;
                        gameover = true;
                        MessageBox.Show("遊戲結束，挑戰者失敗");
                        return;
                    }
                    if (c.Location.Y + c.Size.Height >= this.Size.Height)
                    {
                        Monstermove.Enabled = false;
                        Monsterbutton.Enabled = false;
                        AddMonster.Enabled = false;
                        buttonmove.Enabled = false;
                        right.Enabled = false;
                        left.Enabled = false;
                        up.Enabled = false;
                        down.Enabled = false;
                        gameover = true;
                        MessageBox.Show("遊戲結束，挑戰者失敗");
                        return;
                    }
                    else if(c.Location.X <= 0)
                    {
                        c.Location = new Point(c.Location.X + rd.Next(0, 8), c.Location.Y + rd.Next(1, 4));
                    }
                    else if(c.Location.X+c.Size.Width >= this.Width)
                    {
                        c.Location = new Point(c.Location.X + rd.Next(-8, 0), c.Location.Y + rd.Next(1, 4));
                    }
                    else
                    {
                        foreach(Control bc in this.Controls)
                        {
                            if(bc.Tag == "Button")
                            {
                                if(bc.Location.X+bc.Size.Width >= c.Location.X && bc.Location.Y <= c.Location.Y+c.Size.Height && bc.Location.X<= c.Location.X + c.Size.Width && bc.Location.Y + bc.Size.Height>= c.Location.Y)
                                {
                                    c.Dispose();
                                    bc.Dispose();
                                    grand += 10;
                                    label1.Text = "分數：" + grand + "";
                                    if(grand == 400)
                                    {
                                        BigMonsterHPLengh.Size = new Size(750,10);
                                        BigMonsterHPLengh.BackColor = Color.Red;
                                       this.Controls.Add( new Monster(this.Width, 35));
                                    }
                                    if (grand == 1050)
                                    {
                                        BigMonsterHPLengh.Size = new Size(750, 10);
                                        BigMonsterHPLengh.BackColor = Color.Red;
                                        this.Controls.Add(new Monster(this.Width, 50));
                                    }
                                    if (grand == 1750)
                                    {
                                        BigMonsterHPLengh.Size = new Size(750, 10);
                                        BigMonsterHPLengh.BackColor = Color.Red;
                                        this.Controls.Add(new Monster(this.Width, 75));
                                        for(int i = 0; i < 5; i++)
                                        {
                                            this.Controls.Add(new Monster(this.Width));
                                        }
                                    }
                                }
                            }
                        }
                        c.Location = new Point(c.Location.X + rd.Next(-8, 8), c.Location.Y + rd.Next(1, 4));
                    }
                }
                else if(c.Tag == "BigMonster")
                {
                    Monstermove.Interval = 40;
                    if (c.Location.X + c.Size.Width >= player.Location.X && c.Location.Y <= player.Location.Y + player.Size.Height && c.Location.X <= player.Location.X + player.Size.Width && c.Location.Y + c.Size.Height >= player.Location.Y)
                    {
                        c.Dispose();
                        player.Dispose();
                        Monstermove.Enabled = false;
                        Monsterbutton.Enabled = false;
                        AddMonster.Enabled = false;
                        buttonmove.Enabled = false;
                        right.Enabled = false;
                        left.Enabled = false;
                        up.Enabled = false;
                        down.Enabled = false;
                        gameover = true;
                        MessageBox.Show("遊戲結束，挑戰者失敗");
                        return;
                    }
                    if (c.Location.Y + c.Size.Height >= this.Size.Height)
                    {
                        Monstermove.Enabled = false;
                        Monsterbutton.Enabled = false;
                        AddMonster.Enabled = false;
                        buttonmove.Enabled = false;
                        right.Enabled = false;
                        left.Enabled = false;
                        up.Enabled = false;
                        down.Enabled = false;
                        MessageBox.Show("遊戲結束，挑戰者失敗");
                        return;
                    }
                    else if (c.Location.X <= 0)
                    {
                        c.Location = new Point(c.Location.X + rd.Next(0, BigMonsterMoveRange ), c.Location.Y + 1);
                    }
                    else if (c.Location.X + c.Size.Width >= this.Width)
                    {
                        c.Location = new Point(c.Location.X + rd.Next(BigMonsterMoveRange*-1, 0), c.Location.Y + 1);
                    }
                    else
                    {
                        foreach (Control bc in this.Controls)
                        {
                            if (bc.Tag == "Button")
                            {
                                if (bc.Location.X + bc.Size.Width >= c.Location.X && bc.Location.Y <= c.Location.Y + c.Size.Height && bc.Location.X <= c.Location.X + c.Size.Width && bc.Location.Y + bc.Size.Height >= c.Location.Y)
                                {
                                    bc.Dispose();
                                    BigMonsterHPLengh.Size = new Size(BigMonsterHPLengh.Size.Width-(750/BigMonsterHP),BigMonsterHPLengh.Size.Height);
                                    bigcount++;
                                    if(bigcount >= BigMonsterHP)
                                    {
                                        c.Dispose();
                                        BigMonsterHPLengh.Size = new Size(0,10);

                                        foreach(Control ccc in this.Controls)
                                        {
                                            if(c.Tag == "Monster")
                                            {
                                                c.Dispose();
                                            }    }
                                        if(Lv == "Lv1")
                                        {
                                            label2.Text = "";
                                            skill++;
                                            for (int i = 0; i < skill; i++)
                                            {
                                                label2.Text += "ⓢ";
                                            }
                                            grand += 100;
                                            label1.Text = "分數：" + grand + "";
                                            Monstermove.Enabled = false;
                                            Monsterbutton.Enabled = false;
                                            AddMonster.Enabled = false;
                                            buttonmove.Enabled = false;
                                            right.Enabled = false;
                                            left.Enabled = false;
                                            up.Enabled = false;
                                            down.Enabled = false;
                                            Monstermove.Interval = 20;
                                            AddMonster.Interval = 250;
                                            BigMonsterMoveTimes = 3;
                                            BigMonsterMoveRange = 35;
                                            Lv = "Lv2";
                                            AddMonster.Enabled = true;
                                            LV.labtxt = "Lv2";
                                            MonsterButtonRd = 92;
                                            BigMonsterButtonRd = 75;
                                            BigMonsterHP = 50;
                                            bigcount = 0;
                                            new LV().ShowDialog();
                                            Monstermove.Enabled = true;
                                            Monsterbutton.Enabled = true;
                                            AddMonster.Enabled = true;
                                            buttonmove.Enabled = true;
                                        }
                                        else if(Lv == "Lv2")
                                        {
                                            label2.Text = "";
                                            skill++;
                                            for (int i = 0; i < skill; i++)
                                            {
                                                label2.Text += "ⓢ";
                                            }
                                            grand += 200;
                                            label1.Text = "分數：" + grand + "";
                                            Monstermove.Enabled = false;
                                            Monsterbutton.Enabled = false;
                                            AddMonster.Enabled = false;
                                            buttonmove.Enabled = false;
                                            right.Enabled = false;
                                            left.Enabled = false;
                                            up.Enabled = false;
                                            down.Enabled = false;
                                            Monstermove.Interval = 16;
                                            AddMonster.Interval = 1;
                                            BigMonsterMoveTimes = 3;
                                            BigMonsterMoveRange = 45;
                                            Lv = "Lv3";
                                            AddMonster.Enabled = true;
                                            LV.labtxt = "Lv3";
                                            MonsterButtonRd = 88;
                                            BigMonsterButtonRd = 65;
                                            BigMonsterHP = 75;
                                            bigcount = 0;
                                            new LV().ShowDialog();
                                            Monstermove.Enabled = true;
                                            Monsterbutton.Enabled = true;
                                            AddMonster.Enabled = true;
                                            buttonmove.Enabled = true;
                                        }
                                        else
                                        {
                                            grand += 500;
                                            label1.Text = "分數：" + grand + "";
                                            Monstermove.Enabled = false;
                                            Monsterbutton.Enabled = false;
                                            AddMonster.Enabled = false;
                                            buttonmove.Enabled = false;
                                            right.Enabled = false;
                                            left.Enabled = false;
                                            up.Enabled = false;
                                            down.Enabled = false;
                                            gameover = true;
                                            LV.labtxt = "新年快樂";
                                            new LV().Show();
                                        }
                                    }
                                }
                            }
                        }
                        if (c.Tag == "BigMonster")
                        {
                            aa++;
                            if(aa % BigMonsterMoveTimes == 1)
                            {
                                c.Location = new Point(c.Location.X + rd.Next(BigMonsterMoveRange*-1, BigMonsterMoveRange), c.Location.Y + 1);
                            }
                            c.Location = new Point(c.Location.X + rd.Next(BigMonsterMoveRange * -1, BigMonsterMoveRange), c.Location.Y );
                        }
                        else  c.Location = new Point(c.Location.X + rd.Next(MonsterMoveRange*-1,MonsterMoveRange), c.Location.Y + rd.Next(1, 4));
                        }
                }
            }
        }
        int a = 0, bigcount = 0, aa = 0;
        private void Monsterbutton_Tick(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Tag == "Monster")
                {
                    a = rd.Next(1, 100);
                    if (a >= MonsterButtonRd)
                    {
                        this.Controls.Add(new button(c.Location.X - c.Size.Width / 4+5, c.Location.Y + c.Size.Height, 1));
                    }
                }
                if(c.Tag == "BigMonster")
                {
                    a = rd.Next(1, 100);
                    if (a >= BigMonsterButtonRd)
                    {
                        this.Controls.Add(new button(c.Location.X + c.Size.Width / 2 - rd.Next(1,81), c.Location.Y + c.Size.Height, 1));
                    }
                }
            }
        }
        int MonsterButtonRd = 96;
        int BigMonsterButtonRd = 80;
        int MonsterMoveRange = 8;
        int BigMonsterMoveRange = 20;

        private void shoop_Tick(object sender, EventArgs e)
        {
            shoop.Interval = 200;
            if (Lv == "Lv3")
            {
                button b1 = new button(playerX - 10, playerY);
                button b2 = new button(playerX + 10, playerY);
                this.Controls.Add(b1);
                this.Controls.Add(b2);
            }
            else
            {
                button b1 = new button(playerX, playerY);
                this.Controls.Add(b1);
            }
        }
        private void Clear()
        {
            for(int i = 0; i < 5; i++)
            {
                foreach (Control c in this.Controls)
                {
                    if (c.Tag == "Button" || c.Tag == "MonsterButton" || c.Tag == "Monster" || c.Tag == "BigMonster")
                    {
                        c.Dispose();
                    }
                }
            }
        }

        private void skills_Tick(object sender, EventArgs e)
        {
            Monstermove.Enabled = true;
            Monsterbutton.Enabled = true;
            AddMonster.Enabled = true;
            buttonmove.Enabled = true;
            skills.Enabled = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!stop)
            {
                if (spaceup == true)
                {
                    spaceup = false;
                    shoop.Interval = 1;
                    shoop.Enabled = true;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            spaceup = true;
            shoop.Enabled = false;
        }

        int BigMonsterMoveTimes = 2;
        int BigMonsterHP = 35;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
