using System;

namespace RepeatCounterApp
{
  public class RepeatCounter
  {
    public int CounterRepeats(string userWord, string userString)
    {
      int count = 0;
      int number = 0;
      bool result = int.TryParse(userWord, out number);
      string[] stringArray = userString.Split(' ');

      for (int i = 0; i < stringArray.Length; i++)
      {
        if(userWord != "" && !result && userWord.ToLower() == stringArray[i].ToLower())
        {
          count++;
        }
      }
      return count;
    }
  }
}
