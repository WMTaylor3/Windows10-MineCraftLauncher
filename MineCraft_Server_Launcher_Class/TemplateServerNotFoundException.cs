using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Launcher_Class
{
	class TemplateServerNotFoundException : Exception
	{
		public TemplateServerNotFoundException(string message) : base(message) { }
	}
}
