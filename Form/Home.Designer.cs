namespace Pikachu_team21
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuide
            // 
            this.btnGuide.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGuide.BackgroundImage = global::Pikachu_team21.Properties.Resources.information;
            this.btnGuide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuide.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGuide.Location = new System.Drawing.Point(179, 615);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(70, 70);
            this.btnGuide.TabIndex = 0;
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnContinue.BackgroundImage = global::Pikachu_team21.Properties.Resources.play__1_;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnContinue.Location = new System.Drawing.Point(445, 531);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(70, 70);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnOut
            // 
            this.btnOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOut.BackgroundImage = global::Pikachu_team21.Properties.Resources.exit;
            this.btnOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOut.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnOut.Location = new System.Drawing.Point(981, 615);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(70, 70);
            this.btnOut.TabIndex = 3;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Red;
            this.lblWelcome.Location = new System.Drawing.Point(3, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1224, 422);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStart.BackgroundImage = global::Pikachu_team21.Properties.Resources.power;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnStart.Location = new System.Drawing.Point(718, 531);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 70);
            this.btnStart.TabIndex = 8;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSetting.BackgroundImage = global::Pikachu_team21.Properties.Resources.menu;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSetting.Location = new System.Drawing.Point(848, 572);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(70, 70);
            this.btnSetting.TabIndex = 15;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnTop
            // 
            this.btnTop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTop.BackgroundImage = global::Pikachu_team21.Properties.Resources.brand;
            this.btnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTop.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTop.Location = new System.Drawing.Point(311, 572);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(70, 70);
            this.btnTop.TabIndex = 16;
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pikachu_team21.Properties.Resources.snapedit_1741537818197;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 804);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnGuide);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuide;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnTop;
    }
}