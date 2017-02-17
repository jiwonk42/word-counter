
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
    public void RepeatCounterCheck_ForUserInputHelloGoodbye_1()
    {
      RepeatCounter repeatCounterTest = new RepeatCounter();
      Assert.Equal(1, repeatCounterTest.CounterRepeats("Hello", "Hello Goodbye"));
    }

    [Fact]
    public void RepeatCounterCheck_ForUserInputHelloGoodbyeHello_2()
    {
      RepeatCounter repeatCounterTest = new RepeatCounter();
      Assert.Equal(2, repeatCounterTest.CounterRepeats("Hello", "Hello Goodbye Hello"));
    }

  }
}
