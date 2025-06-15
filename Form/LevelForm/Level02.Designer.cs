namespace Pikachu_team21
{
    partial class level02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level02));
            this.pnLevel2 = new System.Windows.Forms.Panel();
            this.lblLevel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnLevel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLevel2
            // 
            this.pnLevel2.BackColor = System.Drawing.Color.Transparent;
            this.pnLevel2.Controls.Add(this.progressBar1);
            this.pnLevel2.Controls.Add(this.lblLevel);
            this.pnLevel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLevel2.Location = new System.Drawing.Point(0, 0);
            this.pnLevel2.Name = "pnLevel2";
            this.pnLevel2.Size = new System.Drawing.Size(896, 559);
            this.pnLevel2.TabIndex = 0;
            // 
            // lblLevel
            // 
            this.lblLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Stencil", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLevel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLevel.Location = new System.Drawing.Point(256, 178);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(385, 203);
            this.lblLevel.TabIndex = 12;
            this.lblLevel.Text = "LEVEL 2";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(193, 433);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(522, 12);
            this.progressBar1.TabIndex = 18;
            // 
            // level02
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 559);
            this.Controls.Add(this.pnLevel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "level02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu";
            this.Load += new System.EventHandler(this.level02_Load);
            this.pnLevel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLevel2;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}