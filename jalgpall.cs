using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
public class Jalgpall{
  public static void Main(string[] argumendid){

    var players=File.ReadAllLines("jalgpall.txt").Select(rida => rida.Split(' ')).
        Select(m => new{pknimi=m[0], goals=int.Parse(m[1])});

    var playersSortedByGoal=players.OrderBy(player => player.goals);

    Console.WriteLine(
        players
            .OrderBy(player => player.goals)
            .Take(1)
        );


    File.WriteAllLines("sortgoals.txt", 
        playersSortedByGoal.Select(player => player.pknimi+" on löönud "+(player.goals*0.8)+" klubiväravat"));

  }
}