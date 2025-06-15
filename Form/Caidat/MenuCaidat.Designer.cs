namespace Pikachu_team21
{
    partial class frmMenuCaidat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCaidat));
            this.btnSetLevel = new System.Windows.Forms.Button();
            this.btnSetMethod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSetMethod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetLevel
            // 
            this.btnSetLevel.BackgroundImage = global::Pikachu_team21.Properties.Resources.check__1_;
            this.btnSetLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetLevel.Location = new System.Drawing.Point(661, 350);
            this.btnSetLevel.Name = "btnSetLevel";
            this.btnSetLevel.Size = new System.Drawing.Size(45, 45);
            this.btnSetLevel.TabIndex = 0;
            this.btnSetLevel.UseVisualStyleBackColor = true;
            this.btnSetLevel.Click += new System.EventHandler(this.btnSetLevel_Click);
            // 
            // btnSetMethod
            // 
            this.btnSetMethod.BackgroundImage = global::Pikachu_team21.Properties.Resources.check__1_;
            this.btnSetMethod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetMethod.Location = new System.Drawing.Point(661, 184);
            this.btnSetMethod.Name = "btnSetMethod";
            this.btnSetMethod.Size = new System.Drawing.Size(45, 45);
            this.btnSetMethod.TabIndex = 1;
            this.btnSetMethod.UseVisualStyleBackColor = true;
            this.btnSetMethod.Click += new System.EventHandler(this.btnSetMethod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(191, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn màn chơi";
            // 
            // lblSetMethod
            // 
            this.lblSetMethod.AutoSize = true;
            this.lblSetMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblSetMethod.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetMethod.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSetMethod.Location = new System.Drawing.Point(191, 154);
            this.lblSetMethod.Name = "lblSetMethod";
            this.lblSetMethod.Size = new System.Drawing.Size(430, 110);
            this.lblSetMethod.TabIndex = 3;
            this.lblSetMethod.Text = "Cài đặt riêng \r\ncác thuộc tính game";
            this.lblSetMethod.Click += new System.EventHandler(this.lblSetMethod_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Pikachu_team21.Properties.Resources.cancel;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(426, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuCaidat
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Pikachu_team21.Properties.Resources.d1c7f64661b1b68b0215a5a7527838c6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSetMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetMethod);
            this.Controls.Add(this.btnSetLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuCaidat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCaidat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetLevel;
        private System.Windows.Forms.Button btnSetMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSetMethod;
        private System.Windows.Forms.Button button1;
    }
}