using System;
using System.Timers;
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
	public partial class NewServer : Form
	{
		private ServerList _listOfServers;

		public NewServer(ServerList listOfServers)
		{
			InitializeComponent();

			//Copy reference to list of servers.
			_listOfServers = listOfServers;
		}

		private void btnCreateCreate_Click(object sender, EventArgs e)
		{
			if(FormValidityCheck())
			{
				//Make directory for new server and copy files.
				try
				{
					_listOfServers.CreateNewServerDirectory(txtCreateDirectory.Text);
				}
				catch(Exception error)
				{
					MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				PerformInitialization();
			}
			else
			{
				MessageBox.Show("Please ensure all parameters have been given a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show("The server has been sucessfully created", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		//Ensures fields in the form have been populated.
		private bool FormValidityCheck()
		{
			if(
				(txtCreateDirectory.Text.Length > 0) &&
				(txtCreateName.Text.Length > 0) &&
				(txtCreateSub.Text.Length > 0) &&
				(txtCreateSeed.Text.Length > 0) &&
				(groupCreateMode.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
				(comboCreateDifficulty.Text.Length > 0)
			)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		//Pulls the values from the form and passed them to the ServerList InitializeNewServer method.
		private void PerformInitialization()
		{
			string folderName = txtCreateDirectory.Text;
			string serverName = txtCreateName.Text;
			string tagLine = txtCreateSub.Text;
			string seed = txtCreateSeed.Text;
			byte mode = (radioCreateModeCreative.Checked) ? (byte)1 : (byte)0;
			byte difficulty;
				switch(comboCreateDifficulty.Text)
				{
					case "Peaceful":
						difficulty = 0;
						break;
					case "Moderate":
						difficulty = 2;
						break;
					case "Hard":
						difficulty = 3;
						break;
					default:
						difficulty = 1;
						break;
			}
			bool monsters = checkCreateMonsters.Checked;

			_listOfServers.InitializeNewServer(folderName, serverName, tagLine, seed, mode, difficulty, monsters);
		}
	}
}