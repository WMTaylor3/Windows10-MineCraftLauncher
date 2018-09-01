using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Launcher_Class
{
    public class Server
    {
		//Fields
		private string _folderPath;
		private string _folderName;
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
				return _folderName + " (" + _name +")";
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
			pullPropertiesFileContents(directory);

			_folderPath = directory;
			_folderName = Path.GetFileName(_folderPath);
			_name = _propertiesFileContents["level-name"];
			_tagLine = _propertiesFileContents["motd"];
			_seed = _propertiesFileContents["level-seed"];
			try
			{
				Byte.TryParse(_propertiesFileContents["gamemode"], out _mode);
			}
			catch(ArgumentException)
			{
				_mode = 0;
			}
			try
			{
				Byte.TryParse(_propertiesFileContents["difficulty"], out _difficulty);
			}
			catch(ArgumentException)
			{
				_difficulty = 1;
			}
			try
			{
				Boolean.TryParse(_propertiesFileContents["spawn-monsters"], out _monsters);
			}
			catch(ArgumentException)
			{
				_monsters = true;
			}
		}

		//Constructor for new servers.
		public Server(string name, string tagLine, string seed, byte mode, byte difficulty, byte monsters)
		{
			throw new NotImplementedException();
		}

		//Reads all the lines out of the servers properties files and stores them in a string array, one array element per file line.
		//Then splits each array element into a key-value pair and stores it in a dictionary.
		private void pullPropertiesFileContents(string directory)
		{
			string[] file = System.IO.File.ReadAllLines(directory + "\\server.properties");
			_propertiesFileContents = file.Select(item => item.Split('=')).ToDictionary(x => x[0], y => y[1]);
		}
	}
}