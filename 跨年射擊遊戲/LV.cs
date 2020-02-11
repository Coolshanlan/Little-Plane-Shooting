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
    public partial class LV : Form
    {
        public LV()
        {
            InitializeComponent();
            if (labtxt != "新年快樂")
            {
                labtxt = "   " + labtxt;
            }
            else
            {
                label1.Location = new Point(label1.Location.X - 20, label1.Location.Y);
            }
            label1.Text = labtxt;
            if (labtxt == "   Lv.1")
            {
                new Form1().Show();
            }
        }
        int count;
        public static string labtxt = "Lv.1";
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(count >= 40)
            {
                timer1.Enabled = false;
                if(labtxt != "新年快樂") this.Hide();
            }
            else
            {
                label1.Location = new Point(label1.Location.X - 1, label1.Location.Y - 1);
                this.label1.Font = new System.Drawing.Font("微軟正黑體",label1.Font.Size+1, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            }
            count++;
        }

        private void LV_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }
}
