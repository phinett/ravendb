﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Raven.Abstractions.Data;
using Raven.Client.Document;
using System.Linq;

namespace Raven.Tryouts
{
	class Program
	{
		static void Main(string[] args)
		{
			var x = Path.GetDirectoryName(@"F:\");
			Console.WriteLine(x);
		} 
	}
}