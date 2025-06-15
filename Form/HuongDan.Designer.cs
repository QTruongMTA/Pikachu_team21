namespace Pikachu_team21
{
    partial class frmHuongDan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHuongDan));
            this.btnOke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHuongDan = new System.Windows.Forms.PictureBox();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHuongDan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOke
            // 
            this.btnOke.BackColor = System.Drawing.SystemColors.Info;
            this.btnOke.BackgroundImage = global::Pikachu_team21.Properties.Resources.positive_vote;
            this.btnOke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOke.Location = new System.Drawing.Point(426, 485);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(45, 45);
            this.btnOke.TabIndex = 0;
            this.btnOke.UseVisualStyleBackColor = false;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "HƯỚNG DẪN CHƠI GAME PIKACHU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbHuongDan
            // 
            this.pbHuongDan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbHuongDan.BackColor = System.Drawing.Color.Black;
            this.pbHuongDan.Image = global::Pikachu_team21.Properties.Resources.back_10;
            this.pbHuongDan.Location = new System.Drawing.Point(52, 67);
            this.pbHuongDan.Name = "pbHuongDan";
            this.pbHuongDan.Size = new System.Drawing.Size(790, 393);
            this.pbHuongDan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHuongDan.TabIndex = 2;
            this.pbHuongDan.TabStop = false;
            // 
            // btnPhai
            // 
            this.btnPhai.BackColor = System.Drawing.SystemColors.Info;
            this.btnPhai.BackgroundImage = global::Pikachu_team21.Properties.Resources.arrowhead1;
            this.btnPhai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhai.Location = new System.Drawing.Point(849, 246);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(35, 45);
            this.btnPhai.TabIndex = 3;
            this.btnPhai.UseVisualStyleBackColor = false;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.BackColor = System.Drawing.SystemColors.Info;
            this.btnTrai.BackgroundImage = global::Pikachu_team21.Properties.Resources.arrowhead___Copy;
            this.btnTrai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrai.Location = new System.Drawing.Point(10, 246);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(35, 45);
            this.btnTrai.TabIndex = 4;
            this.btnTrai.UseVisualStyleBackColor = false;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // frmHuongDan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Pikachu_team21.Properties.Resources._02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 559);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.pbHuongDan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOke);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu";
            ((System.ComponentModel.ISupportInitialize)(this.pbHuongDan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHuongDan;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnTrai;
    }
}