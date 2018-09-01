using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Launcher_Class
{
	class ServerList
	{
		private string _serversDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
		private List<Server> _servers;

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

		public ServerList() { }

		public void populateList()
		{
			string[] serverNames = System.IO.Directory.GetDirectories(_serversDirectory);
			foreach (string directory in Directory.GetDirectories(_serversDirectory))
			{
				Servers.Add(new Server(directory));
			}
		}
	}
}
