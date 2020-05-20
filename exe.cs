using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Failipunktid
{
	public static void Main(string[] arg)
	{
		//inimestePikkus();
		//inimesteMassiiv();
		inimesteTabelMassiiv();
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

	public static void inimesteTabelMassiiv() {
		var inimene_linn=File.ReadAllLines("pikkused_tabel.txt").Select(rida => rida.Split(' ')).
			Select(m => new{eesnimi=m[0], linn=m[1]});

		var linn_sorted=inimene_linn.OrderBy(linnad => -linnad.linn);

		    File.WriteAllLines("linnad_sorted.txt", 
        linn_sorted.Select(linnad => linnad.linn));
	}


    public static string Sorenda(string tekst) {
      return string.Join(" ", tekst.ToCharArray());
    }
}