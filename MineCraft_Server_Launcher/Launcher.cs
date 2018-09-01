using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineCraft_Server_Launcher
{
	public partial class Launcher : Form
	{
		public Launcher()
		{
			InitializeComponent();
		}

		private void btnNewServer_Click(object sender, EventArgs e)
		{
			NewServer NewServerForm = new NewServer();
			NewServerForm.ShowDialog();
		}

		private void btnExistingServer_Click(object sender, EventArgs e)
		{
			ExistingServer ExistingServerForm = new ExistingServer();
			ExistingServerForm.ShowDialog();
		}
	}
}
