using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Launcher_Class
{
	public class ServerList
	{
		private string _serversDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
		private List<Server> _servers = new List<Server>();

		public List<Server> Servers
		{
			get
			{
				return _servers;
			}
			set
			{
				_servers = value;
			}
		}

		public ServerList()
		{
			PopulateListWithExistingServerDirectorys();
		}

		//Populates the list with any existing servers.
		private void PopulateListWithExistingServerDirectorys()
		{
			string[] serverNames = System.IO.Directory.GetDirectories(_serversDirectory);
			foreach (string directory in Directory.GetDirectories(_serversDirectory))
			{
				Servers.Add(new Server(directory));
			}
		}

		//Makes a new server directory with the folder name provided by the directory attribute and copys the contents of the ServerTemplate folder into it.
		public void CreateNewServerDirectory(string folderName)
		{
			if(Directory.Exists(_serversDirectory + "\\ServerTemplate"))
			{
				if (!Directory.Exists(_serversDirectory + "\\" + folderName))
				{
					//Nominal path.
					//Copying folder structure.
					foreach (string sourceSubFolder in Directory.GetDirectories(_serversDirectory + "\\ServerTemplate", "*", SearchOption.AllDirectories))
					{
						Directory.CreateDirectory(sourceSubFolder.Replace(_serversDirectory + "\\ServerTemplate", _serversDirectory + "\\" + folderName));
					}
					//Copy the files themselves.
					foreach (string sourceFile in Directory.GetFiles(_serversDirectory + "\\ServerTemplate", "*", SearchOption.AllDirectories))
					{
						string destinationFile = sourceFile.Replace(_serversDirectory + "\\ServerTemplate", _serversDirectory + "\\" + folderName);
						File.Copy(sourceFile, destinationFile, false);
					}
				}
				else
				{
					//The server already exists.
					throw new Pre_ExistingServerException("A server already exists with that directory name.");
				}

			}
			else
			{
				//The ServerTemplate no longer exists.
				throw new TemplateServerNotFoundException("The template server directory could not be found.");
			}

		}

		//Initializes a new server with supplied attributes. Essentially passes through to Server.cs constructor.
		//Adds server to Server list.
		public void InitializeNewServer(string folderName, string serverName, string tagLine, string seed, byte mode, byte difficulty, bool monsters)
		{
			Servers.Add(new Server(_serversDirectory, folderName, serverName, tagLine, seed, mode, difficulty, monsters));
		}
	}
}