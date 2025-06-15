namespace Pikachu_team21
{
    partial class frmTamDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTamDung));
            this.btnTieptuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTieptuc.BackgroundImage = global::Pikachu_team21.Properties.Resources.play__1_;
            this.btnTieptuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTieptuc.Location = new System.Drawing.Point(86, 63);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(45, 45);
            this.btnTieptuc.TabIndex = 0;
            this.btnTieptuc.UseVisualStyleBackColor = false;
            this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThoat.BackgroundImage = global::Pikachu_team21.Properties.Resources.exit;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(262, 63);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(45, 45);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTamDung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Pikachu_team21.Properties.Resources.hoenn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(393, 149);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTieptuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTamDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TamDung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTieptuc;
        private System.Windows.Forms.Button btnThoat;
    }
}