using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineCraft_Server_Launcher_Class;

namespace MineCraft_Server_Launcher
{
	public partial class ExistingServer : Form
	{
		private ServerList _listOfServers;

		public ExistingServer(ServerList listOfServers)
		{
			InitializeComponent();
			_listOfServers = listOfServers;
			RepopulateComboBoxes();
		}

		private void RepopulateComboBoxes()
		{
			comboDeleteServer.Items.Clear();
			comboModifyServer.Items.Clear();
			comboResumeServer.Items.Clear();
			foreach (Server s in _listOfServers.Servers)
			{
				if (s.FolderName != "ServerTemplate")
				{
					comboDeleteServer.Items.Add(s.Title);
					comboModifyServer.Items.Add(s.Title);
					comboResumeServer.Items.Add(s.Title);
				}
			}
		}

		private void btnDeleteDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to delete the server" + Environment.NewLine + comboDeleteServer.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				_listOfServers.DeleteServer(comboDeleteServer.Text);
				RepopulateComboBoxes();
			}
		}

		private void btnModifySelect_Click(object sender, EventArgs e)
		{
			
		}

		private void btnModifyModify_Click(object sender, EventArgs e)
		{

		}

		private void btnResumeResume_Click(object sender, EventArgs e)
		{
			_listOfServers.BeginServer(comboResumeServer.Text);
		}
	}
}
