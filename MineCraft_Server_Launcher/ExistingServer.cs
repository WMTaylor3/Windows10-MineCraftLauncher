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
		private ServerList _listOfServers = new ServerList();

		public ExistingServer()
		{
			InitializeComponent();

			//Populate drop down lists
			foreach(Server s in _listOfServers.Servers)
			{
				if (s.FolderName != "ServerTemplate")
				{
					comboDeleteServer.Items.Add(s.Title);
					comboModifyServer.Items.Add(s.Title);
					comboResumeServer.Items.Add(s.Title);
				}
			}
		}

		private void btnCreateCreate_Click(object sender, EventArgs e)
		{

		}

		private void btnDeleteDelete_Click(object sender, EventArgs e)
		{

		}

		private void btnModifySelect_Click(object sender, EventArgs e)
		{

		}

		private void btnModifyModify_Click(object sender, EventArgs e)
		{

		}

		private void btnResumeResume_Click(object sender, EventArgs e)
		{

		}

		private void PopulateServerLists()
		{

		}

		private void ExistingServer_Load(object sender, EventArgs e)
		{

		}
	}
}
