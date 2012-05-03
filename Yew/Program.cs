using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yew {
	class Program {
		static void Main(string[] args) {
			var c = new Compiler();
			c.OutputName = "a.exe";
			c.Compile(args);
		}
	}
}
