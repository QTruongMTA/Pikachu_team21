namespace Pikachu_team21
{
    partial class frmDongGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDongGame));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBye = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(856, 174);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁM ƠN BẠN NHIỀU NHA\r\nVÌ ĐÃ CHƠI GAME CỦA TỤI MÌNH\r\nHEHE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBye
            // 
            this.lblBye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblBye.BackColor = System.Drawing.Color.Transparent;
            this.lblBye.Font = new System.Drawing.Font("Times New Roman", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBye.ForeColor = System.Drawing.Color.Navy;
            this.lblBye.Location = new System.Drawing.Point(20, 312);
            this.lblBye.Name = "lblBye";
            this.lblBye.Size = new System.Drawing.Size(856, 119);
            this.lblBye.TabIndex = 1;
            this.lblBye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBye.UseWaitCursor = true;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmDongGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Pikachu_team21.Properties.Resources.run;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 559);
            this.Controls.Add(this.lblBye);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDongGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu";
            this.Load += new System.EventHandler(this.frmOut_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBye;
        private System.Windows.Forms.Timer timer2;
    }
}