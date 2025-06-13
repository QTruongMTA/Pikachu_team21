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
            this.lblSetLV = new System.Windows.Forms.Label();
            this.lblSetPic = new System.Windows.Forms.Label();
            this.lblSetTime = new System.Windows.Forms.Label();
            this.lblSetVol = new System.Windows.Forms.Label();
            this.lblSetSound = new System.Windows.Forms.Label();
            this.updTime = new System.Windows.Forms.DomainUpDown();
            this.updMusic = new System.Windows.Forms.DomainUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.updLevel = new System.Windows.Forms.DomainUpDown();
            this.updPokemon = new System.Windows.Forms.DomainUpDown();
            this.updVolume = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // lblSetLV
            // 
            this.lblSetLV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetLV.AutoSize = true;
            this.lblSetLV.BackColor = System.Drawing.Color.Transparent;
            this.lblSetLV.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetLV.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSetLV.Location = new System.Drawing.Point(101, 59);
            this.lblSetLV.Name = "lblSetLV";
            this.lblSetLV.Size = new System.Drawing.Size(98, 28);
            this.lblSetLV.TabIndex = 5;
            this.lblSetLV.Text = "CẤP ĐỘ";
            // 
            // lblSetPic
            // 
            this.lblSetPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetPic.AutoSize = true;
            this.lblSetPic.BackColor = System.Drawing.Color.Transparent;
            this.lblSetPic.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPic.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSetPic.Location = new System.Drawing.Point(101, 135);
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
            this.lblSetTime.Location = new System.Drawing.Point(101, 211);
            this.lblSetTime.Name = "lblSetTime";
            this.lblSetTime.Size = new System.Drawing.Size(234, 28);
            this.lblSetTime.TabIndex = 7;
            this.lblSetTime.Text = "CHẾ ĐỘ THỜI GIAN";
            // 
            // lblSetVol
            // 
            this.lblSetVol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetVol.AutoSize = true;
            this.lblSetVol.BackColor = System.Drawing.Color.Transparent;
            this.lblSetVol.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetVol.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSetVol.Location = new System.Drawing.Point(101, 287);
            this.lblSetVol.Name = "lblSetVol";
            this.lblSetVol.Size = new System.Drawing.Size(179, 28);
            this.lblSetVol.TabIndex = 8;
            this.lblSetVol.Text = "COMING SOON";
            this.lblSetVol.Click += new System.EventHandler(this.lblSetVol_Click);
            // 
            // lblSetSound
            // 
            this.lblSetSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSetSound.AutoSize = true;
            this.lblSetSound.BackColor = System.Drawing.Color.Transparent;
            this.lblSetSound.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetSound.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSetSound.Location = new System.Drawing.Point(101, 363);
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
            this.updTime.Location = new System.Drawing.Point(370, 215);
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
            this.updMusic.Location = new System.Drawing.Point(370, 363);
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
            this.btnAccept.Location = new System.Drawing.Point(137, 455);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(70, 70);
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
            this.btnCancel.Location = new System.Drawing.Point(383, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 70);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // updLevel
            // 
            this.updLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updLevel.AutoSize = true;
            this.updLevel.BackColor = System.Drawing.Color.LightCyan;
            this.updLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updLevel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.updLevel.Items.Add("Dễ");
            this.updLevel.Items.Add("Trung bình");
            this.updLevel.Items.Add("Khó");
            this.updLevel.Items.Add("Hủy diệt");
            this.updLevel.Location = new System.Drawing.Point(370, 63);
            this.updLevel.Name = "updLevel";
            this.updLevel.ReadOnly = true;
            this.updLevel.Size = new System.Drawing.Size(120, 26);
            this.updLevel.TabIndex = 14;
            this.updLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updLevel.SelectedItemChanged += new System.EventHandler(this.updLevel_SelectedItemChanged);
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
            this.updPokemon.Location = new System.Drawing.Point(370, 139);
            this.updPokemon.Name = "updPokemon";
            this.updPokemon.ReadOnly = true;
            this.updPokemon.Size = new System.Drawing.Size(120, 26);
            this.updPokemon.TabIndex = 15;
            this.updPokemon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updPokemon.SelectedItemChanged += new System.EventHandler(this.updPokemon_SelectedItemChanged);
            // 
            // updVolume
            // 
            this.updVolume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updVolume.AutoSize = true;
            this.updVolume.BackColor = System.Drawing.Color.LightCyan;
            this.updVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updVolume.ForeColor = System.Drawing.Color.MidnightBlue;
            this.updVolume.Items.Add("Siêu nhỏ");
            this.updVolume.Items.Add("Đủ nghe");
            this.updVolume.Items.Add("Đau tai");
            this.updVolume.Items.Add("Cháy loa");
            this.updVolume.Location = new System.Drawing.Point(370, 291);
            this.updVolume.Name = "updVolume";
            this.updVolume.ReadOnly = true;
            this.updVolume.Size = new System.Drawing.Size(120, 26);
            this.updVolume.TabIndex = 16;
            this.updVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSetting
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Pikachu_team21.Properties.Resources.Changeee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(590, 556);
            this.Controls.Add(this.updVolume);
            this.Controls.Add(this.updPokemon);
            this.Controls.Add(this.updLevel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.updMusic);
            this.Controls.Add(this.updTime);
            this.Controls.Add(this.lblSetSound);
            this.Controls.Add(this.lblSetVol);
            this.Controls.Add(this.lblSetTime);
            this.Controls.Add(this.lblSetPic);
            this.Controls.Add(this.lblSetLV);
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
        private System.Windows.Forms.Label lblSetLV;
        private System.Windows.Forms.Label lblSetPic;
        private System.Windows.Forms.Label lblSetTime;
        private System.Windows.Forms.Label lblSetVol;
        private System.Windows.Forms.Label lblSetSound;
        private System.Windows.Forms.DomainUpDown updTime;
        private System.Windows.Forms.DomainUpDown updMusic;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DomainUpDown updLevel;
        private System.Windows.Forms.DomainUpDown updPokemon;
        private System.Windows.Forms.DomainUpDown updVolume;
    }
}