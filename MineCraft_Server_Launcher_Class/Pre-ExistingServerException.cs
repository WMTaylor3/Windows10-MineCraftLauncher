using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Launcher_Class
{
	class Pre_ExistingServerException : Exception
	{
		public Pre_ExistingServerException(string message) : base(message) { }
	}
}
