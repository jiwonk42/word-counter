using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
  public class RepeatCounter
  {
    public int CounterRepeats(string userWord, string userString)
    {
      int count = 0;
      if(userString.Contains(userWord))
      {
        count++;
      }
      return count;
    }
  }
}
