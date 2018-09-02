﻿namespace MineCraft_Server_Launcher
{
	partial class ExistingServer
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
			this.lblMainTitle = new System.Windows.Forms.Label();
			this.fmt1 = new System.Windows.Forms.Label();
			this.groupDelete = new System.Windows.Forms.GroupBox();
			this.btnDeleteDelete = new System.Windows.Forms.Button();
			this.lblDeleteServer = new System.Windows.Forms.Label();
			this.comboDeleteServer = new System.Windows.Forms.ComboBox();
			this.groupModify = new System.Windows.Forms.GroupBox();
			this.btnModifySelect = new System.Windows.Forms.Button();
			this.comboModifyDifficulty = new System.Windows.Forms.ComboBox();
			this.btnModifyModify = new System.Windows.Forms.Button();
			this.lblModifyDifficulty = new System.Windows.Forms.Label();
			this.checkModifyMonsters = new System.Windows.Forms.CheckBox();
			this.groupModifyMode = new System.Windows.Forms.GroupBox();
			this.radioModifyModeCreative = new System.Windows.Forms.RadioButton();
			this.radioModifyModeSurvival = new System.Windows.Forms.RadioButton();
			this.lblModifyServer = new System.Windows.Forms.Label();
			this.comboModifyServer = new System.Windows.Forms.ComboBox();
			this.groupResume = new System.Windows.Forms.GroupBox();
			this.lblResumeServer = new System.Windows.Forms.Label();
			this.btnResumeResume = new System.Windows.Forms.Button();
			this.comboResumeServer = new System.Windows.Forms.ComboBox();
			this.groupDelete.SuspendLayout();
			this.groupModify.SuspendLayout();
			this.groupModifyMode.SuspendLayout();
			this.groupResume.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblMainTitle
			// 
			this.lblMainTitle.AutoSize = true;
			this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
			this.lblMainTitle.Location = new System.Drawing.Point(216, 16);
			this.lblMainTitle.Name = "lblMainTitle";
			this.lblMainTitle.Size = new System.Drawing.Size(365, 39);
			this.lblMainTitle.TabIndex = 0;
			this.lblMainTitle.Text = "Existing Server Control";
			// 
			// fmt1
			// 
			this.fmt1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fmt1.Location = new System.Drawing.Point(-8, 72);
			this.fmt1.Name = "fmt1";
			this.fmt1.Size = new System.Drawing.Size(810, 2);
			this.fmt1.TabIndex = 1;
			// 
			// groupDelete
			// 
			this.groupDelete.Controls.Add(this.btnDeleteDelete);
			this.groupDelete.Controls.Add(this.lblDeleteServer);
			this.groupDelete.Controls.Add(this.comboDeleteServer);
			this.groupDelete.Location = new System.Drawing.Point(0, 80);
			this.groupDelete.Name = "groupDelete";
			this.groupDelete.Size = new System.Drawing.Size(266, 336);
			this.groupDelete.TabIndex = 3;
			this.groupDelete.TabStop = false;
			this.groupDelete.Text = "Delete Server";
			// 
			// btnDeleteDelete
			// 
			this.btnDeleteDelete.Location = new System.Drawing.Point(80, 296);
			this.btnDeleteDelete.Name = "btnDeleteDelete";
			this.btnDeleteDelete.Size = new System.Drawing.Size(96, 23);
			this.btnDeleteDelete.TabIndex = 1;
			this.btnDeleteDelete.Text = "Delete";
			this.btnDeleteDelete.UseVisualStyleBackColor = true;
			this.btnDeleteDelete.Click += new System.EventHandler(this.btnDeleteDelete_Click);
			// 
			// lblDeleteServer
			// 
			this.lblDeleteServer.AutoSize = true;
			this.lblDeleteServer.Location = new System.Drawing.Point(16, 32);
			this.lblDeleteServer.Name = "lblDeleteServer";
			this.lblDeleteServer.Size = new System.Drawing.Size(41, 13);
			this.lblDeleteServer.TabIndex = 4;
			this.lblDeleteServer.Text = "Server:";
			// 
			// comboDeleteServer
			// 
			this.comboDeleteServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDeleteServer.FormattingEnabled = true;
			this.comboDeleteServer.Location = new System.Drawing.Point(16, 48);
			this.comboDeleteServer.Name = "comboDeleteServer";
			this.comboDeleteServer.Size = new System.Drawing.Size(232, 21);
			this.comboDeleteServer.TabIndex = 0;
			this.comboDeleteServer.SelectedIndexChanged += new System.EventHandler(this.comboDeleteServer_SelectedIndexChanged);
			// 
			// groupModify
			// 
			this.groupModify.Controls.Add(this.btnModifySelect);
			this.groupModify.Controls.Add(this.comboModifyDifficulty);
			this.groupModify.Controls.Add(this.btnModifyModify);
			this.groupModify.Controls.Add(this.lblModifyDifficulty);
			this.groupModify.Controls.Add(this.checkModifyMonsters);
			this.groupModify.Controls.Add(this.groupModifyMode);
			this.groupModify.Controls.Add(this.lblModifyServer);
			this.groupModify.Controls.Add(this.comboModifyServer);
			this.groupModify.Location = new System.Drawing.Point(264, 80);
			this.groupModify.Name = "groupModify";
			this.groupModify.Size = new System.Drawing.Size(266, 336);
			this.groupModify.TabIndex = 5;
			this.groupModify.TabStop = false;
			this.groupModify.Text = "Modify Server";
			// 
			// btnModifySelect
			// 
			this.btnModifySelect.Location = new System.Drawing.Point(88, 88);
			this.btnModifySelect.Name = "btnModifySelect";
			this.btnModifySelect.Size = new System.Drawing.Size(96, 23);
			this.btnModifySelect.TabIndex = 1;
			this.btnModifySelect.Text = "Select";
			this.btnModifySelect.UseVisualStyleBackColor = true;
			this.btnModifySelect.Click += new System.EventHandler(this.btnModifySelect_Click);
			// 
			// comboModifyDifficulty
			// 
			this.comboModifyDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModifyDifficulty.FormattingEnabled = true;
			this.comboModifyDifficulty.Items.AddRange(new object[] {
            "Peaceful",
            "Easy",
            "Moderate",
            "Hard"});
			this.comboModifyDifficulty.Location = new System.Drawing.Point(16, 216);
			this.comboModifyDifficulty.Name = "comboModifyDifficulty";
			this.comboModifyDifficulty.Size = new System.Drawing.Size(240, 21);
			this.comboModifyDifficulty.TabIndex = 3;
			// 
			// btnModifyModify
			// 
			this.btnModifyModify.Location = new System.Drawing.Point(88, 296);
			this.btnModifyModify.Name = "btnModifyModify";
			this.btnModifyModify.Size = new System.Drawing.Size(96, 23);
			this.btnModifyModify.TabIndex = 5;
			this.btnModifyModify.Text = "Modify";
			this.btnModifyModify.UseVisualStyleBackColor = true;
			this.btnModifyModify.Click += new System.EventHandler(this.btnModifyModify_Click);
			// 
			// lblModifyDifficulty
			// 
			this.lblModifyDifficulty.AutoSize = true;
			this.lblModifyDifficulty.Location = new System.Drawing.Point(16, 200);
			this.lblModifyDifficulty.Name = "lblModifyDifficulty";
			this.lblModifyDifficulty.Size = new System.Drawing.Size(47, 13);
			this.lblModifyDifficulty.TabIndex = 16;
			this.lblModifyDifficulty.Text = "Difficulty";
			// 
			// checkModifyMonsters
			// 
			this.checkModifyMonsters.AutoSize = true;
			this.checkModifyMonsters.Location = new System.Drawing.Point(16, 256);
			this.checkModifyMonsters.Name = "checkModifyMonsters";
			this.checkModifyMonsters.Size = new System.Drawing.Size(69, 17);
			this.checkModifyMonsters.TabIndex = 4;
			this.checkModifyMonsters.Text = "Monsters";
			this.checkModifyMonsters.UseVisualStyleBackColor = true;
			// 
			// groupModifyMode
			// 
			this.groupModifyMode.Controls.Add(this.radioModifyModeCreative);
			this.groupModifyMode.Controls.Add(this.radioModifyModeSurvival);
			this.groupModifyMode.Location = new System.Drawing.Point(16, 128);
			this.groupModifyMode.Name = "groupModifyMode";
			this.groupModifyMode.Size = new System.Drawing.Size(240, 56);
			this.groupModifyMode.TabIndex = 2;
			this.groupModifyMode.TabStop = false;
			this.groupModifyMode.Text = "Mode:";
			// 
			// radioModifyModeCreative
			// 
			this.radioModifyModeCreative.AutoSize = true;
			this.radioModifyModeCreative.Location = new System.Drawing.Point(168, 24);
			this.radioModifyModeCreative.Name = "radioModifyModeCreative";
			this.radioModifyModeCreative.Size = new System.Drawing.Size(64, 17);
			this.radioModifyModeCreative.TabIndex = 1;
			this.radioModifyModeCreative.TabStop = true;
			this.radioModifyModeCreative.Text = "Creative";
			this.radioModifyModeCreative.UseVisualStyleBackColor = true;
			// 
			// radioModifyModeSurvival
			// 
			this.radioModifyModeSurvival.AutoSize = true;
			this.radioModifyModeSurvival.Location = new System.Drawing.Point(16, 24);
			this.radioModifyModeSurvival.Name = "radioModifyModeSurvival";
			this.radioModifyModeSurvival.Size = new System.Drawing.Size(63, 17);
			this.radioModifyModeSurvival.TabIndex = 0;
			this.radioModifyModeSurvival.TabStop = true;
			this.radioModifyModeSurvival.Text = "Survival";
			this.radioModifyModeSurvival.UseVisualStyleBackColor = true;
			// 
			// lblModifyServer
			// 
			this.lblModifyServer.AutoSize = true;
			this.lblModifyServer.Location = new System.Drawing.Point(16, 32);
			this.lblModifyServer.Name = "lblModifyServer";
			this.lblModifyServer.Size = new System.Drawing.Size(41, 13);
			this.lblModifyServer.TabIndex = 5;
			this.lblModifyServer.Text = "Server:";
			// 
			// comboModifyServer
			// 
			this.comboModifyServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboModifyServer.FormattingEnabled = true;
			this.comboModifyServer.Location = new System.Drawing.Point(16, 48);
			this.comboModifyServer.Name = "comboModifyServer";
			this.comboModifyServer.Size = new System.Drawing.Size(232, 21);
			this.comboModifyServer.TabIndex = 0;
			this.comboModifyServer.SelectedIndexChanged += new System.EventHandler(this.comboModifyServer_SelectedIndexChanged);
			// 
			// groupResume
			// 
			this.groupResume.Controls.Add(this.lblResumeServer);
			this.groupResume.Controls.Add(this.btnResumeResume);
			this.groupResume.Controls.Add(this.comboResumeServer);
			this.groupResume.Location = new System.Drawing.Point(528, 80);
			this.groupResume.Name = "groupResume";
			this.groupResume.Size = new System.Drawing.Size(266, 336);
			this.groupResume.TabIndex = 6;
			this.groupResume.TabStop = false;
			this.groupResume.Text = "Resume Server";
			// 
			// lblResumeServer
			// 
			this.lblResumeServer.AutoSize = true;
			this.lblResumeServer.Location = new System.Drawing.Point(16, 32);
			this.lblResumeServer.Name = "lblResumeServer";
			this.lblResumeServer.Size = new System.Drawing.Size(41, 13);
			this.lblResumeServer.TabIndex = 13;
			this.lblResumeServer.Text = "Server:";
			// 
			// btnResumeResume
			// 
			this.btnResumeResume.Location = new System.Drawing.Point(88, 296);
			this.btnResumeResume.Name = "btnResumeResume";
			this.btnResumeResume.Size = new System.Drawing.Size(96, 23);
			this.btnResumeResume.TabIndex = 1;
			this.btnResumeResume.Text = "Resume";
			this.btnResumeResume.UseVisualStyleBackColor = true;
			this.btnResumeResume.Click += new System.EventHandler(this.btnResumeResume_Click);
			// 
			// comboResumeServer
			// 
			this.comboResumeServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboResumeServer.FormattingEnabled = true;
			this.comboResumeServer.Location = new System.Drawing.Point(16, 48);
			this.comboResumeServer.Name = "comboResumeServer";
			this.comboResumeServer.Size = new System.Drawing.Size(232, 21);
			this.comboResumeServer.TabIndex = 0;
			this.comboResumeServer.SelectedIndexChanged += new System.EventHandler(this.comboResumeServer_SelectedIndexChanged);
			// 
			// ExistingServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 416);
			this.Controls.Add(this.groupResume);
			this.Controls.Add(this.groupModify);
			this.Controls.Add(this.groupDelete);
			this.Controls.Add(this.fmt1);
			this.Controls.Add(this.lblMainTitle);
			this.Name = "ExistingServer";
			this.Text = "Existing";
			this.groupDelete.ResumeLayout(false);
			this.groupDelete.PerformLayout();
			this.groupModify.ResumeLayout(false);
			this.groupModify.PerformLayout();
			this.groupModifyMode.ResumeLayout(false);
			this.groupModifyMode.PerformLayout();
			this.groupResume.ResumeLayout(false);
			this.groupResume.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMainTitle;
		private System.Windows.Forms.Label fmt1;
		private System.Windows.Forms.GroupBox groupDelete;
		private System.Windows.Forms.GroupBox groupModify;
		private System.Windows.Forms.GroupBox groupResume;
		private System.Windows.Forms.Button btnDeleteDelete;
		private System.Windows.Forms.Label lblDeleteServer;
		private System.Windows.Forms.ComboBox comboDeleteServer;
		private System.Windows.Forms.Button btnModifyModify;
		private System.Windows.Forms.Label lblModifyDifficulty;
		private System.Windows.Forms.CheckBox checkModifyMonsters;
		private System.Windows.Forms.GroupBox groupModifyMode;
		private System.Windows.Forms.RadioButton radioModifyModeCreative;
		private System.Windows.Forms.RadioButton radioModifyModeSurvival;
		private System.Windows.Forms.Label lblModifyServer;
		private System.Windows.Forms.ComboBox comboModifyServer;
		private System.Windows.Forms.Label lblResumeServer;
		private System.Windows.Forms.Button btnResumeResume;
		private System.Windows.Forms.ComboBox comboResumeServer;
		private System.Windows.Forms.ComboBox comboModifyDifficulty;
		private System.Windows.Forms.Button btnModifySelect;
	}
}

