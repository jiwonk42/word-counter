
using Xunit;
using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounterCheck_ForUserInputHelloGoodbye_0()
    {
      RepeatCounter repeatCounterTest = new RepeatCounter();
      Assert.Equal(0, repeatCounterTest.CounterRepeats("Hello", "Goodbye"));
    }

    [Fact]
    public void RepeatCounterCheck_ForUserInputHelloHelloGoodbye_1()
    {
      RepeatCounter repeatCounterTest = new RepeatCounter();
      Assert.Equal(0, repeatCounterTest.CounterRepeats("Hello", "Goodbye"));
    }
  }
}
