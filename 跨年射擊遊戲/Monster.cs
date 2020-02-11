using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 跨年射擊遊戲
{
    class Monster:PictureBox
    {
        Random rd = new Random();
        int a;
        public Monster(int width)
        {
            a = rd.Next(1, 7);
            switch (a)
            {
                case 1:
                    this.Image = Properties.Resources._1;
                    break;
                case 2:
                    this.Image = Properties.Resources._2;
                    break;
                case 3:
                    this.Image = Properties.Resources._567978b5c83e8_1024;
                    break;
                case 4:
                    this.Image = Properties.Resources.M4;
                    break;
                case 5:
                    this.Image = Properties.Resources.M5;
                    break;
                case 6:
                    this.Image = Properties.Resources.M6;
                    break;
            }
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new System.Drawing.Size(50, 50);
            this.Location = new System.Drawing.Point(rd.Next(1, width - 20), 0);
            this.Tag = "Monster";
        }
        public Monster(int width , int HP)
        {
            a = rd.Next(1, 7);
            switch (a)
            {
                case 1:
                    this.Image = Properties.Resources._1;
                    break;
                case 2:
                    this.Image = Properties.Resources._2;
                    break;
                case 3:
                    this.Image = Properties.Resources._567978b5c83e8_1024;
                    break;
                case 4:
                    this.Image = Properties.Resources.M4;
                    break;
                case 5:
                    this.Image = Properties.Resources.M5;
                    break;
                case 6:
                    this.Image = Properties.Resources.M6;
                    break;
            }
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new System.Drawing.Size(100, 100);
            this.Location = new System.Drawing.Point(rd.Next(1, width - 20), 0);
            this.Tag = "BigMonster";
        }
    }
}
