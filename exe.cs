using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Failipunktid
{
	public static void Main(string[] arg)
	{
		//inimestePikkus();
		inimesteMassiiv();
	}

	public static void inimestePikkus() {
		Console.WriteLine(File.ReadAllLines("pikkused.txt").Select(p => double.Parse(p))
		      .OrderBy(p => p).Take(1));
	}

	public static void inimesteMassiiv() {
		string[] eesnimed = { "Juku", "Kati", "Katrin", "Madis" };
		IEnumerable<string> vastus=eesnimed.Select(Sorenda);

		foreach(String element in eesnimed){
			char[] item = element.ToCharArray();
			
        } 
	}

    public static string Sorenda(string tekst) {
      return string.Join(" ", tekst.ToCharArray());
    }
}