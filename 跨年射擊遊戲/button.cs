using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 跨年射擊遊戲
{
    class button : PictureBox
    {
        public button( int x , int y)
        {
            this.BackColor = System.Drawing.Color.Yellow;
            this.Tag = "Button";
            this.Location = new System.Drawing.Point(x+32, y);
            this.Size = new System.Drawing.Size(5,15);
        }
        public button(int x, int y,int t)
        {
            this.BackColor = System.Drawing.Color.White;
            this.Tag = "MonsterButton";
            this.Location = new System.Drawing.Point(x + 32, y);
            this.Size = new System.Drawing.Size(5, 5);
        }
    }
}
