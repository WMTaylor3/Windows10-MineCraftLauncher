using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Launcher_Class
{
    public class Server
    {
		private string _folderPath;
		private string _name;
		private string _tagLine;
		private string _seed;
		private byte _mode;
		private byte _difficulty;
		private bool _monsters;
		private Dictionary<string, string> _propertiesFileContents;

		//Constructor for existing servers.
		public Server(string directory)
		{
			pullPropertiesFileContents(directory);

			_folderPath = directory;
			_name = _propertiesFileContents["level-name"];
			_tagLine = _propertiesFileContents["motd"];
			_seed = _propertiesFileContents["level-seed"];
			_mode = Byte.Parse(_propertiesFileContents["gamemode"]);
			_difficulty = Byte.Parse(_propertiesFileContents["difficulty"]);
			_monsters = Boolean.Parse(_propertiesFileContents["spawn_monsters"]);
		}

		//Constructor for new servers.
		public Server(string name, string tagLine, string seed, byte mode, byte difficulty, byte monsters)
		{
			throw new NotImplementedException();
		}

		private void pullPropertiesFileContents(string directory)
		{
			string[] file = System.IO.File.ReadAllLines(directory + System.IO.Path.PathSeparator + "server.properties");
			_propertiesFileContents = file.Select(item => item.Split('=')).ToDictionary(s => s[0], s => s[1]);
		}
	}
}
