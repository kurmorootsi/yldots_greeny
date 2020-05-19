using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Failipunktid
{
    public static void Main(string[] arg)
    {
          punktid();
    }



	public static void punktid() {
Console.WriteLine(File.ReadAllLines("punktid.txt").Select(p => double.Parse(p))
		      .OrderBy(p => p).Skip(1).Take(3).Average());
	}
}