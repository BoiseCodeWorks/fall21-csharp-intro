using System;
using System.Collections.Generic;

namespace RollerDrome
{
  public abstract class Die
  {
    private Random _r = new Random();
    private List<int> RollHistory = new List<int>();

    public int Min { get; } = 1;
    public abstract int Max { get; }

    public int Roll()
    {
      var result = _r.Next(Min, Max + 1);
      RollHistory.Add(result);
      return result;
    }

    /// <summary>
    /// this method will prints all of the rolls ever rolled for this die 
    /// </summary>
    public void PrintHistory()
    {
      System.Console.WriteLine("------------- ROLL HISTORY ------------");
      RollHistory.ForEach(roll => System.Console.WriteLine(roll));
      System.Console.WriteLine("------------- END ROLL HISTORY ------------");
    }

    /// <summary>
    /// prints the last x number of rolls from the die history
    /// </summary>
    /// <param name="lastXRolls"> this number will be normalized </param>
    public void PrintHistory(int lastXRolls)
    {
      System.Console.WriteLine("------------- ROLL HISTORY ------------");

      // normalize the rollcount
      if (lastXRolls > RollHistory.Count)
      {
        lastXRolls = RollHistory.Count;
      }

      for (int i = RollHistory.Count - 1; i >= (RollHistory.Count - lastXRolls); i--)
      {
        System.Console.WriteLine(RollHistory[i]);
      }
      System.Console.WriteLine("------------- END ROLL HISTORY ------------");
    }

  }
}