namespace Pikachu_team21
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.lblSetPic = new System.Windows.Forms.Label();
            this.lblSetTime = new System.Windows.Forms.Label();
            this.lblSetTurn = new System.Windows.Forms.Label();
            this.lblSetSound = new System.Windows.Forms.Label();
            this.updTime = new System.Windows.Forms.DomainUpDown();
            this.updMusic = new System.Windows.Forms.DomainUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.updPokemon = new System.Windows.Forms.DomainUpDown();
            this.updTurn = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // lblSetPic
            // 
            this.lblSetPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetPic.AutoSize = true;
            this.lblSetPic.BackColor = System.Drawing.Color.Transparent;
            this.lblSetPic.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPic.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSetPic.Location = new System.Drawing.Point(176, 94);
            this.lblSetPic.Name = "lblSetPic";
            this.lblSetPic.Size = new System.Drawing.Size(230, 28);
            this.lblSetPic.TabIndex = 6;
            this.lblSetPic.Text = "SỐ LOẠI POKEMON";
            // 
            // lblSetTime
            // 
            this.lblSetTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetTime.AutoSize = true;
            this.lblSetTime.BackColor = System.Drawing.Color.Transparent;
            this.lblSetTime.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSetTime.Location = new System.Drawing.Point(176, 170);
            this.lblSetTime.Name = "lblSetTime";
            this.lblSetTime.Size = new System.Drawing.Size(234, 28);
            this.lblSetTime.TabIndex = 7;
            this.lblSetTime.Text = "CHẾ ĐỘ THỜI GIAN";
            // 
            // lblSetTurn
            // 
            this.lblSetTurn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetTurn.AutoSize = true;
            this.lblSetTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblSetTurn.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetTurn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSetTurn.Location = new System.Drawing.Point(176, 246);
            this.lblSetTurn.Name = "lblSetTurn";
            this.lblSetTurn.Size = new System.Drawing.Size(254, 28);
            this.lblSetTurn.TabIndex = 8;
            this.lblSetTurn.Text = "SỐ ĐOẠN THẲNG NỐI\r\n";
            this.lblSetTurn.Click += new System.EventHandler(this.lblSetVol_Click);
            // 
            // lblSetSound
            // 
            this.lblSetSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetSound.AutoSize = true;
            this.lblSetSound.BackColor = System.Drawing.Color.Transparent;
            this.lblSetSound.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetSound.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSetSound.Location = new System.Drawing.Point(176, 322);
            this.lblSetSound.Name = "lblSetSound";
            this.lblSetSound.Size = new System.Drawing.Size(136, 28);
            this.lblSetSound.TabIndex = 9;
            this.lblSetSound.Text = "NHẠC NỀN";
            // 
            // updTime
            // 
            this.updTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updTime.AutoSize = true;
            this.updTime.BackColor = System.Drawing.Color.LightCyan;
            this.updTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updTime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.updTime.Items.Add("300s");
            this.updTime.Items.Add("500s");
            this.updTime.Items.Add("700s");
            this.updTime.Items.Add("Vô hạn");
            this.updTime.Location = new System.Drawing.Point(600, 174);
            this.updTime.Name = "updTime";
            this.updTime.ReadOnly = true;
            this.updTime.Size = new System.Drawing.Size(120, 26);
            this.updTime.TabIndex = 10;
            this.updTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updTime.SelectedItemChanged += new System.EventHandler(this.updTime_SelectedItemChanged);
            // 
            // updMusic
            // 
            this.updMusic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updMusic.AutoSize = true;
            this.updMusic.BackColor = System.Drawing.Color.LightCyan;
            this.updMusic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updMusic.ForeColor = System.Drawing.Color.MidnightBlue;
            this.updMusic.Items.Add("Theme01");
            this.updMusic.Items.Add("Theme02");
            this.updMusic.Items.Add("Theme03");
            this.updMusic.Items.Add("Theme04");
            this.updMusic.Items.Add("Theme05");
            this.updMusic.Location = new System.Drawing.Point(600, 322);
            this.updMusic.Name = "updMusic";
            this.updMusic.ReadOnly = true;
            this.updMusic.Size = new System.Drawing.Size(120, 26);
            this.updMusic.TabIndex = 11;
            this.updMusic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updMusic.SelectedItemChanged += new System.EventHandler(this.updMusic_SelectedItemChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAccept.BackgroundImage = global::Pikachu_team21.Properties.Resources.check__1_;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.Location = new System.Drawing.Point(277, 456);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(45, 45);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCancel.BackgroundImage = global::Pikachu_team21.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(550, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(45, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // updPokemon
            // 
            this.updPokemon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updPokemon.AutoSize = true;
            this.updPokemon.BackColor = System.Drawing.Color.LightCyan;
            this.updPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updPokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updPokemon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.updPokemon.Items.Add("8");
            this.updPokemon.Items.Add("16");
            this.updPokemon.Items.Add("24");
            this.updPokemon.Items.Add("36");
            this.updPokemon.Items.Add("46");
            this.updPokemon.Location = new System.Drawing.Point(600, 98);
            this.updPokemon.Name = "updPokemon";
            this.updPokemon.ReadOnly = true;
            this.updPokemon.Size = new System.Drawing.Size(120, 26);
            this.updPokemon.TabIndex = 15;
            this.updPokemon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updPokemon.SelectedItemChanged += new System.EventHandler(this.updPokemon_SelectedItemChanged);
            // 
            // updTurn
            // 
            this.updTurn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updTurn.AutoSize = true;
            this.updTurn.BackColor = System.Drawing.Color.LightCyan;
            this.updTurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updTurn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updTurn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.updTurn.Items.Add("2");
            this.updTurn.Items.Add("3");
            this.updTurn.Items.Add("4");
            this.updTurn.Items.Add("5");
            this.updTurn.Location = new System.Drawing.Point(600, 250);
            this.updTurn.Name = "updTurn";
            this.updTurn.ReadOnly = true;
            this.updTurn.Size = new System.Drawing.Size(120, 26);
            this.updTurn.TabIndex = 16;
            this.updTurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updTurn.SelectedItemChanged += new System.EventHandler(this.updTurn_SelectedItemChanged);
            // 
            // frmSetting
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::Pikachu_team21.Properties.Resources.a9e290f6914cc118a0b26d075ffd2556;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(896, 559);
            this.Controls.Add(this.updTurn);
            this.Controls.Add(this.updPokemon);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.updMusic);
            this.Controls.Add(this.updTime);
            this.Controls.Add(this.lblSetSound);
            this.Controls.Add(this.lblSetTurn);
            this.Controls.Add(this.lblSetTime);
            this.Controls.Add(this.lblSetPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSetPic;
        private System.Windows.Forms.Label lblSetTime;
        private System.Windows.Forms.Label lblSetTurn;
        private System.Windows.Forms.Label lblSetSound;
        private System.Windows.Forms.DomainUpDown updTime;
        private System.Windows.Forms.DomainUpDown updMusic;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DomainUpDown updPokemon;
        private System.Windows.Forms.DomainUpDown updTurn;
    }
}