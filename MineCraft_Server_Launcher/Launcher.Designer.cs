namespace MineCraft_Server_Launcher
{
	partial class Launcher
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
			this.btnNewServer = new System.Windows.Forms.Button();
			this.btnExistingServer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblMainTitle
			// 
			this.lblMainTitle.AutoSize = true;
			this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
			this.lblMainTitle.Location = new System.Drawing.Point(16, 16);
			this.lblMainTitle.Name = "lblMainTitle";
			this.lblMainTitle.Size = new System.Drawing.Size(236, 39);
			this.lblMainTitle.TabIndex = 5;
			this.lblMainTitle.Text = "Server Control";
			// 
			// btnNewServer
			// 
			this.btnNewServer.Location = new System.Drawing.Point(24, 72);
			this.btnNewServer.Name = "btnNewServer";
			this.btnNewServer.Size = new System.Drawing.Size(96, 23);
			this.btnNewServer.TabIndex = 6;
			this.btnNewServer.Text = "New Server";
			this.btnNewServer.UseVisualStyleBackColor = true;
			this.btnNewServer.Click += new System.EventHandler(this.btnNewServer_Click);
			// 
			// btnExistingServer
			// 
			this.btnExistingServer.Location = new System.Drawing.Point(152, 72);
			this.btnExistingServer.Name = "btnExistingServer";
			this.btnExistingServer.Size = new System.Drawing.Size(96, 23);
			this.btnExistingServer.TabIndex = 7;
			this.btnExistingServer.Text = "Existing Server";
			this.btnExistingServer.UseVisualStyleBackColor = true;
			this.btnExistingServer.Click += new System.EventHandler(this.btnExistingServer_Click);
			// 
			// Launcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 106);
			this.Controls.Add(this.btnExistingServer);
			this.Controls.Add(this.btnNewServer);
			this.Controls.Add(this.lblMainTitle);
			this.Name = "Launcher";
			this.Text = "Launcher";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMainTitle;
		private System.Windows.Forms.Button btnNewServer;
		private System.Windows.Forms.Button btnExistingServer;
	}
}