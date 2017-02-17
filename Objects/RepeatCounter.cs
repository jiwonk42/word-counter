using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
  public class RepeatCounter
  {
    public int CounterRepeats(string userWord, string userString)
    {
      int count = 0;
      string[] stringArray = userString.Split(' ');

      for (int i = 0; i < stringArray.Length; i++)
      {
        if(userWord == stringArray[i])
        {
          count++;
        }
      }
      return count;
    }
  }
}
