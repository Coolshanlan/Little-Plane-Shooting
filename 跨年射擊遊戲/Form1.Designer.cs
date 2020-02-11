namespace 跨年射擊遊戲
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.right = new System.Windows.Forms.Timer(this.components);
            this.left = new System.Windows.Forms.Timer(this.components);
            this.buttonmove = new System.Windows.Forms.Timer(this.components);
            this.down = new System.Windows.Forms.Timer(this.components);
            this.up = new System.Windows.Forms.Timer(this.components);
            this.AddMonster = new System.Windows.Forms.Timer(this.components);
            this.Monstermove = new System.Windows.Forms.Timer(this.components);
            this.Monsterbutton = new System.Windows.Forms.Timer(this.components);
            this.shoop = new System.Windows.Forms.Timer(this.components);
            this.BigMonsterHPLengh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skills = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BigMonsterHPLengh)).BeginInit();
            this.SuspendLayout();
            // 
            // right
            // 
            this.right.Interval = 10;
            this.right.Tag = "timer";
            this.right.Tick += new System.EventHandler(this.right_Tick);
            // 
            // left
            // 
            this.left.Interval = 10;
            this.left.Tag = "timer";
            this.left.Tick += new System.EventHandler(this.left_Tick);
            // 
            // buttonmove
            // 
            this.buttonmove.Enabled = true;
            this.buttonmove.Interval = 10;
            this.buttonmove.Tag = "timer";
            this.buttonmove.Tick += new System.EventHandler(this.buttonmove_Tick);
            // 
            // down
            // 
            this.down.Interval = 10;
            this.down.Tag = "timer";
            this.down.Tick += new System.EventHandler(this.down_Tick);
            // 
            // up
            // 
            this.up.Interval = 10;
            this.up.Tag = "timer";
            this.up.Tick += new System.EventHandler(this.up_Tick);
            // 
            // AddMonster
            // 
            this.AddMonster.Enabled = true;
            this.AddMonster.Interval = 500;
            this.AddMonster.Tag = "timer";
            this.AddMonster.Tick += new System.EventHandler(this.AddMonster_Tick);
            // 
            // Monstermove
            // 
            this.Monstermove.Enabled = true;
            this.Monstermove.Interval = 40;
            this.Monstermove.Tag = "timer";
            this.Monstermove.Tick += new System.EventHandler(this.Monstermove_Tick);
            // 
            // Monsterbutton
            // 
            this.Monsterbutton.Enabled = true;
            this.Monsterbutton.Tag = "timer";
            this.Monsterbutton.Tick += new System.EventHandler(this.Monsterbutton_Tick);
            // 
            // shoop
            // 
            this.shoop.Interval = 1000;
            this.shoop.Tag = "timer";
            this.shoop.Tick += new System.EventHandler(this.shoop_Tick);
            // 
            // BigMonsterHPLengh
            // 
            this.BigMonsterHPLengh.Location = new System.Drawing.Point(16, 22);
            this.BigMonsterHPLengh.Margin = new System.Windows.Forms.Padding(4);
            this.BigMonsterHPLengh.Name = "BigMonsterHPLengh";
            this.BigMonsterHPLengh.Size = new System.Drawing.Size(13, 25);
            this.BigMonsterHPLengh.TabIndex = 1;
            this.BigMonsterHPLengh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(483, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "分數：0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 1040);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "ⓢ";
            // 
            // skills
            // 
            this.skills.Interval = 2500;
            this.skills.Tag = "timer";
            this.skills.Tick += new System.EventHandler(this.skills_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1084, 1088);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BigMonsterHPLengh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.BigMonsterHPLengh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer right;
        private System.Windows.Forms.Timer left;
        private System.Windows.Forms.Timer buttonmove;
        private System.Windows.Forms.Timer down;
        private System.Windows.Forms.Timer up;
        private System.Windows.Forms.Timer AddMonster;
        private System.Windows.Forms.Timer Monstermove;
        private System.Windows.Forms.Timer Monsterbutton;
        private System.Windows.Forms.Timer shoop;
        private System.Windows.Forms.PictureBox BigMonsterHPLengh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer skills;
    }
}

