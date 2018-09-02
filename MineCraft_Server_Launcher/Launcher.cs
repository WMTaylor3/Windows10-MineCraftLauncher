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
	public partial class Launcher : Form
	{
		private ServerList _listOfServers = new ServerList();

		public Launcher()
		{
			InitializeComponent();
		}

		private void btnNewServer_Click(object sender, EventArgs e)
		{
			NewServer NewServerForm = new NewServer(_listOfServers);
			NewServerForm.ShowDialog();
		}

		private void btnExistingServer_Click(object sender, EventArgs e)
		{
			ExistingServer ExistingServerForm = new ExistingServer(_listOfServers);
			ExistingServerForm.ShowDialog();
		}
	}
}
