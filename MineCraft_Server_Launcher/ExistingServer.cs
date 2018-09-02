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
			PushStateOfInterfaceComponents();
		}

		private void btnModifyModify_Click(object sender, EventArgs e)
		{
			if (FormValidityCheck())
			{
				byte mode = 0;
				byte difficulty = 0;
				bool monsters = false;

				PullStateOfInterfaceComponents(out mode, out difficulty, out monsters);
				_listOfServers.UpdateServersModifiableProperties(comboModifyServer.Text, mode, difficulty, monsters);
			}
			else
			{
				MessageBox.Show("Invalid Parameters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnResumeResume_Click(object sender, EventArgs e)
		{
			_listOfServers.BeginServer(comboResumeServer.Text);
		}

		private void comboDeleteServer_SelectedIndexChanged(object sender, EventArgs e)
		{
			ClearModifySection();
		}

		private void comboModifyServer_SelectedIndexChanged(object sender, EventArgs e)
		{
			ClearModifySection();
		}

		private void comboResumeServer_SelectedIndexChanged(object sender, EventArgs e)
		{
			ClearModifySection();
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

		private void PushStateOfInterfaceComponents()
		{
			byte mode = 0;
			byte difficulty = 0;
			bool monsters = false;

			_listOfServers.RetrieveServersModifiableProperties(comboModifyServer.Text, out mode, out difficulty, out monsters);

			switch(mode)
			{
				case 0:
					radioModifyModeSurvival.Checked = true;
					radioModifyModeCreative.Checked = false;
					break;
				case 1:
					radioModifyModeSurvival.Checked = false;
					radioModifyModeCreative.Checked = true;
					break;
			}

			switch(difficulty)
			{
				case 0:
					comboModifyDifficulty.Text = "Peaceful";
					break;
				case 1:
					comboModifyDifficulty.Text = "Easy";
					break;
				case 2:
					comboModifyDifficulty.Text = "Moderate";
					break;
				case 3:
					comboModifyDifficulty.Text = "Hard";
					break;
			}

			checkModifyMonsters.Checked = monsters;
		}

		private void PullStateOfInterfaceComponents(out byte mode, out byte difficulty, out bool monsters)
		{
			switch(radioModifyModeSurvival.Checked)
			{
				case false:
					mode = 1;
					break;
				default:
					mode = 0;
					break;
			}

			switch (comboModifyDifficulty.Text)
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

			monsters = checkModifyMonsters.Checked;
		}

		private void ClearModifySection()
		{
			comboModifyServer.SelectedValue = 0;
			radioModifyModeCreative.Checked = false;
			radioModifyModeSurvival.Checked = false;
			comboModifyDifficulty.SelectedValue = 0;
			checkModifyMonsters.Checked = false;
		}

		private bool FormValidityCheck()
		{
			if (
				(comboModifyServer.Text.Length > 0) &&
				(groupModifyMode.Controls.OfType<RadioButton>().Any(x => x.Checked)) &&
				(comboModifyDifficulty.Text.Length > 0)
			)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
