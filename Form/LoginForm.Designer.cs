namespace Pikachu_team21
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnLog = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLog
            // 
            this.pnLog.BackColor = System.Drawing.Color.Transparent;
            this.pnLog.Controls.Add(this.lblWelcome);
            this.pnLog.Controls.Add(this.txtPlayerName);
            this.pnLog.Controls.Add(this.btnLogin);
            this.pnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLog.Location = new System.Drawing.Point(0, 0);
            this.pnLog.Name = "pnLog";
            this.pnLog.Size = new System.Drawing.Size(1230, 804);
            this.pnLog.TabIndex = 0;
            this.pnLog.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Crimson;
            this.lblWelcome.Location = new System.Drawing.Point(239, 58);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(752, 140);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "CHÀO MỪNG ĐẾN VỚI \r\nGAME PIKACHU";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.AcceptsReturn = true;
            this.txtPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPlayerName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(320, 478);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(590, 49);
            this.txtPlayerName.TabIndex = 4;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.BackgroundImage = global::Pikachu_team21.Properties.Resources.play;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogin.Location = new System.Drawing.Point(570, 589);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(1);
            this.btnLogin.Size = new System.Drawing.Size(90, 90);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pikachu_team21.Properties.Resources.kanto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 804);
            this.Controls.Add(this.pnLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pikachu";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnLog.ResumeLayout(false);
            this.pnLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLog;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnLogin;
    }
}

