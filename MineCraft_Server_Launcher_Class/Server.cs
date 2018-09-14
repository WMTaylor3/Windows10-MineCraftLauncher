using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Launcher_Class
{
	public class Server
	{
		//Fields
		private string _folderName;
		private string _completePath;
		private string _name;
		private string _tagLine;
		private string _seed;
		private byte _mode;
		private byte _difficulty;
		private bool _monsters;
		private Dictionary<string, string> _propertiesFileContents;

		//Properties
		public string Title
		{
			get
			{
				return _folderName + " (" + _name + ")";
			}
		}
		public string FolderName
		{
			get
			{
				return _folderName;
			}
		}

		//Methods
		//Constructor for existing servers.
		public Server(string directory)
		{
			_folderName = Path.GetFileName(directory);
			_completePath = directory;

			PullPropertiesFileContents(directory);

			_name = _propertiesFileContents["level-name"];
			_tagLine = _propertiesFileContents["motd"];
			_seed = _propertiesFileContents["level-seed"];
			try
			{
				Byte.TryParse(_propertiesFileContents["gamemode"], out _mode);
			}
			catch (ArgumentException)
			{
				_mode = 0;
			}
			try
			{
				Byte.TryParse(_propertiesFileContents["difficulty"], out _difficulty);
			}
			catch (ArgumentException)
			{
				_difficulty = 1;
			}
			try
			{
				Boolean.TryParse(_propertiesFileContents["spawn-monsters"], out _monsters);
			}
			catch (ArgumentException)
			{
				_monsters = true;
			}
		}

		//Constructor for new servers.
		public Server(string directory, string folderName, string serverName, string tagLine, string seed, byte mode, byte difficulty, bool monsters)
		{
			_folderName = folderName;
			_completePath = directory + "\\" + folderName;
			_name = serverName;
			_tagLine = tagLine;
			_seed = seed;
			_mode = mode;
			_difficulty = difficulty;
			_monsters = monsters;

			PullPropertiesFileContents(directory);
			ModifyPropertiesValues();
			PushPropertiesValuesToFile();
		}

		//Reads all the lines out of the servers properties files and stores them in a string array, one array element per file line.
		//Then splits each array element into a key-value pair and stores it in a dictionary.
		private void PullPropertiesFileContents(string directory)
		{
			string[] file = System.IO.File.ReadAllLines(_completePath + "\\server.properties");
			file = file.Skip(2).ToArray<string>();
			_propertiesFileContents = file.Select(item => item.Split('=')).ToDictionary(x => x[0], y => y[1]);
		}

		//Modifys the properties values read from the file to be equal to the values stored in the fields.
		private void ModifyPropertiesValues()
		{
			_propertiesFileContents["level-name"] = _name;
			_propertiesFileContents["motd"] = _tagLine;
			_propertiesFileContents["level-seed"] = _seed;
			_propertiesFileContents["gamemode"] = _mode.ToString();
			_propertiesFileContents["difficulty"] = _difficulty.ToString();
			_propertiesFileContents["spawn-monsters"] = (_monsters) ? "true" : "false";
		}

		//Writes the attributes to a server.properties file based on _propertiesFileContents which should have been populated with the template servers contents.
		private void PushPropertiesValuesToFile()
		{
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(_completePath + "\\" + "server.properties"))
			{
				foreach (KeyValuePair<string, string> kvp in _propertiesFileContents)
				{
					string line = kvp.Key + "=" + kvp.Value;
					file.WriteLine(line);
				}
			}
		}

		//Begins the server by passing its start command to a CMD process.
		public void Begin()
		{
			Process p = new Process();
			ProcessStartInfo psi = new ProcessStartInfo();
			p.StartInfo.FileName = "CMD.EXE";
			p.StartInfo.Arguments = "/C cd " + _completePath + "& java -server -Xmx4096M -Xms4096M -XX:+UseConcMarkSweepGC -XX:+UseParNewGC -XX:+CMSIncrementalPacing -XX:ParallelGCThreads=2 -XX:+AggressiveOpts -jar server.jar nogui";
			p.Start();
			p.WaitForExit();
		}
	}
}