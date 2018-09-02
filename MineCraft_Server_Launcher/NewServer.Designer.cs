namespace MineCraft_Server_Launcher
{
	partial class NewServer
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
			this.groupCreate = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCreateName = new System.Windows.Forms.TextBox();
			this.comboCreateDifficulty = new System.Windows.Forms.ComboBox();
			this.lblCreateDifficulty = new System.Windows.Forms.Label();
			this.btnCreateCreate = new System.Windows.Forms.Button();
			this.checkCreateMonsters = new System.Windows.Forms.CheckBox();
			this.groupCreateMode = new System.Windows.Forms.GroupBox();
			this.radioCreateModeCreative = new System.Windows.Forms.RadioButton();
			this.radioCreateModeSurvival = new System.Windows.Forms.RadioButton();
			this.lblCreateSeed = new System.Windows.Forms.Label();
			this.lblCreateSubtitle = new System.Windows.Forms.Label();
			this.lblCreateName = new System.Windows.Forms.Label();
			this.txtCreateSeed = new System.Windows.Forms.TextBox();
			this.txtCreateSub = new System.Windows.Forms.TextBox();
			this.txtCreateDirectory = new System.Windows.Forms.TextBox();
			this.fmt1 = new System.Windows.Forms.Label();
			this.lblMainTitle = new System.Windows.Forms.Label();
			this.groupCreate.SuspendLayout();
			this.groupCreateMode.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupCreate
			// 
			this.groupCreate.Controls.Add(this.label1);
			this.groupCreate.Controls.Add(this.txtCreateName);
			this.groupCreate.Controls.Add(this.comboCreateDifficulty);
			this.groupCreate.Controls.Add(this.lblCreateDifficulty);
			this.groupCreate.Controls.Add(this.btnCreateCreate);
			this.groupCreate.Controls.Add(this.checkCreateMonsters);
			this.groupCreate.Controls.Add(this.groupCreateMode);
			this.groupCreate.Controls.Add(this.lblCreateSeed);
			this.groupCreate.Controls.Add(this.lblCreateSubtitle);
			this.groupCreate.Controls.Add(this.lblCreateName);
			this.groupCreate.Controls.Add(this.txtCreateSeed);
			this.groupCreate.Controls.Add(this.txtCreateSub);
			this.groupCreate.Controls.Add(this.txtCreateDirectory);
			this.groupCreate.Location = new System.Drawing.Point(0, 80);
			this.groupCreate.Name = "groupCreate";
			this.groupCreate.Size = new System.Drawing.Size(266, 464);
			this.groupCreate.TabIndex = 1;
			this.groupCreate.TabStop = false;
			this.groupCreate.Text = "Create Server";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Name:";
			// 
			// txtCreateName
			// 
			this.txtCreateName.Location = new System.Drawing.Point(16, 104);
			this.txtCreateName.Name = "txtCreateName";
			this.txtCreateName.Size = new System.Drawing.Size(232, 20);
			this.txtCreateName.TabIndex = 1;
			// 
			// comboCreateDifficulty
			// 
			this.comboCreateDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboCreateDifficulty.FormattingEnabled = true;
			this.comboCreateDifficulty.Items.AddRange(new object[] {
            "Peaceful",
            "Easy",
            "Moderate",
            "Hard"});
			this.comboCreateDifficulty.Location = new System.Drawing.Point(16, 344);
			this.comboCreateDifficulty.Name = "comboCreateDifficulty";
			this.comboCreateDifficulty.Size = new System.Drawing.Size(232, 21);
			this.comboCreateDifficulty.TabIndex = 5;
			// 
			// lblCreateDifficulty
			// 
			this.lblCreateDifficulty.AutoSize = true;
			this.lblCreateDifficulty.Location = new System.Drawing.Point(16, 328);
			this.lblCreateDifficulty.Name = "lblCreateDifficulty";
			this.lblCreateDifficulty.Size = new System.Drawing.Size(47, 13);
			this.lblCreateDifficulty.TabIndex = 12;
			this.lblCreateDifficulty.Text = "Difficulty";
			// 
			// btnCreateCreate
			// 
			this.btnCreateCreate.Location = new System.Drawing.Point(88, 424);
			this.btnCreateCreate.Name = "btnCreateCreate";
			this.btnCreateCreate.Size = new System.Drawing.Size(96, 23);
			this.btnCreateCreate.TabIndex = 7;
			this.btnCreateCreate.Text = "Create";
			this.btnCreateCreate.UseVisualStyleBackColor = true;
			this.btnCreateCreate.Click += new System.EventHandler(this.btnCreateCreate_Click);
			// 
			// checkCreateMonsters
			// 
			this.checkCreateMonsters.AutoSize = true;
			this.checkCreateMonsters.Location = new System.Drawing.Point(16, 384);
			this.checkCreateMonsters.Name = "checkCreateMonsters";
			this.checkCreateMonsters.Size = new System.Drawing.Size(69, 17);
			this.checkCreateMonsters.TabIndex = 6;
			this.checkCreateMonsters.Text = "Monsters";
			this.checkCreateMonsters.UseVisualStyleBackColor = true;
			// 
			// groupCreateMode
			// 
			this.groupCreateMode.Controls.Add(this.radioCreateModeCreative);
			this.groupCreateMode.Controls.Add(this.radioCreateModeSurvival);
			this.groupCreateMode.Location = new System.Drawing.Point(16, 256);
			this.groupCreateMode.Name = "groupCreateMode";
			this.groupCreateMode.Size = new System.Drawing.Size(232, 56);
			this.groupCreateMode.TabIndex = 4;
			this.groupCreateMode.TabStop = false;
			this.groupCreateMode.Text = "Mode:";
			// 
			// radioCreateModeCreative
			// 
			this.radioCreateModeCreative.AutoSize = true;
			this.radioCreateModeCreative.Location = new System.Drawing.Point(152, 24);
			this.radioCreateModeCreative.Name = "radioCreateModeCreative";
			this.radioCreateModeCreative.Size = new System.Drawing.Size(64, 17);
			this.radioCreateModeCreative.TabIndex = 1;
			this.radioCreateModeCreative.TabStop = true;
			this.radioCreateModeCreative.Text = "Creative";
			this.radioCreateModeCreative.UseVisualStyleBackColor = true;
			// 
			// radioCreateModeSurvival
			// 
			this.radioCreateModeSurvival.AutoSize = true;
			this.radioCreateModeSurvival.Location = new System.Drawing.Point(16, 24);
			this.radioCreateModeSurvival.Name = "radioCreateModeSurvival";
			this.radioCreateModeSurvival.Size = new System.Drawing.Size(63, 17);
			this.radioCreateModeSurvival.TabIndex = 0;
			this.radioCreateModeSurvival.Text = "Survival";
			this.radioCreateModeSurvival.UseVisualStyleBackColor = true;
			// 
			// lblCreateSeed
			// 
			this.lblCreateSeed.AutoSize = true;
			this.lblCreateSeed.Location = new System.Drawing.Point(16, 200);
			this.lblCreateSeed.Name = "lblCreateSeed";
			this.lblCreateSeed.Size = new System.Drawing.Size(35, 13);
			this.lblCreateSeed.TabIndex = 10;
			this.lblCreateSeed.Text = "Seed:";
			// 
			// lblCreateSubtitle
			// 
			this.lblCreateSubtitle.AutoSize = true;
			this.lblCreateSubtitle.Location = new System.Drawing.Point(16, 144);
			this.lblCreateSubtitle.Name = "lblCreateSubtitle";
			this.lblCreateSubtitle.Size = new System.Drawing.Size(45, 13);
			this.lblCreateSubtitle.TabIndex = 9;
			this.lblCreateSubtitle.Text = "Tagline:";
			// 
			// lblCreateName
			// 
			this.lblCreateName.AutoSize = true;
			this.lblCreateName.Location = new System.Drawing.Point(16, 32);
			this.lblCreateName.Name = "lblCreateName";
			this.lblCreateName.Size = new System.Drawing.Size(52, 13);
			this.lblCreateName.TabIndex = 7;
			this.lblCreateName.Text = "Directory:";
			// 
			// txtCreateSeed
			// 
			this.txtCreateSeed.Location = new System.Drawing.Point(16, 216);
			this.txtCreateSeed.Name = "txtCreateSeed";
			this.txtCreateSeed.Size = new System.Drawing.Size(232, 20);
			this.txtCreateSeed.TabIndex = 3;
			// 
			// txtCreateSub
			// 
			this.txtCreateSub.Location = new System.Drawing.Point(16, 160);
			this.txtCreateSub.Name = "txtCreateSub";
			this.txtCreateSub.Size = new System.Drawing.Size(232, 20);
			this.txtCreateSub.TabIndex = 2;
			// 
			// txtCreateDirectory
			// 
			this.txtCreateDirectory.Location = new System.Drawing.Point(16, 48);
			this.txtCreateDirectory.Name = "txtCreateDirectory";
			this.txtCreateDirectory.Size = new System.Drawing.Size(232, 20);
			this.txtCreateDirectory.TabIndex = 0;
			// 
			// fmt1
			// 
			this.fmt1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fmt1.Location = new System.Drawing.Point(0, 72);
			this.fmt1.Name = "fmt1";
			this.fmt1.Size = new System.Drawing.Size(267, 2);
			this.fmt1.TabIndex = 0;
			// 
			// lblMainTitle
			// 
			this.lblMainTitle.AutoSize = true;
			this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
			this.lblMainTitle.Location = new System.Drawing.Point(32, 16);
			this.lblMainTitle.Name = "lblMainTitle";
			this.lblMainTitle.Size = new System.Drawing.Size(195, 39);
			this.lblMainTitle.TabIndex = 1;
			this.lblMainTitle.Text = "New Server";
			// 
			// NewServer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 541);
			this.Controls.Add(this.fmt1);
			this.Controls.Add(this.lblMainTitle);
			this.Controls.Add(this.groupCreate);
			this.Name = "NewServer";
			this.Text = "New";
			this.groupCreate.ResumeLayout(false);
			this.groupCreate.PerformLayout();
			this.groupCreateMode.ResumeLayout(false);
			this.groupCreateMode.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupCreate;
		private System.Windows.Forms.ComboBox comboCreateDifficulty;
		private System.Windows.Forms.Label lblCreateDifficulty;
		private System.Windows.Forms.Button btnCreateCreate;
		private System.Windows.Forms.CheckBox checkCreateMonsters;
		private System.Windows.Forms.GroupBox groupCreateMode;
		private System.Windows.Forms.RadioButton radioCreateModeCreative;
		private System.Windows.Forms.RadioButton radioCreateModeSurvival;
		private System.Windows.Forms.Label lblCreateSeed;
		private System.Windows.Forms.Label lblCreateSubtitle;
		private System.Windows.Forms.Label lblCreateName;
		private System.Windows.Forms.TextBox txtCreateSeed;
		private System.Windows.Forms.TextBox txtCreateSub;
		private System.Windows.Forms.TextBox txtCreateDirectory;
		private System.Windows.Forms.Label fmt1;
		private System.Windows.Forms.Label lblMainTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCreateName;
	}
}