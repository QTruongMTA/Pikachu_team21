namespace Pikachu_team21
{
    partial class frmGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuide));
            this.btnOke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOke
            // 
            this.btnOke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOke.BackgroundImage = global::Pikachu_team21.Properties.Resources.positive_vote;
            this.btnOke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOke.Location = new System.Drawing.Point(527, 515);
            this.btnOke.Name = "btnOke";
            this.btnOke.Size = new System.Drawing.Size(70, 70);
            this.btnOke.TabIndex = 0;
            this.btnOke.UseVisualStyleBackColor = false;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // frmGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pikachu_team21.Properties.Resources._02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 690);
            this.Controls.Add(this.btnOke);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOke;
    }
}