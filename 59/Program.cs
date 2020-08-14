using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace FunctionalStuff
{
	class Program
		static void Main(string[] args)
		{
			var sw = new Stopwatch();
			sw.Start();
			Console.WriteLine(Problem59.Solve("cipher1.txt"));
			sw.Stop();
			Console.WriteLine("Time: " + sw.ElapsedMilliseconds);
			sw.Reset();
		}
	}
}
