
using Xunit;
using System;

namespace RepeatCounterApp
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounterCheck_ForUserInput_0()
    {
      RepeatCounter repeatCounterTest = new RepeatCounter();
      Assert.Equal(0, repeatCounterTest.CounterRepeats("", ""));
    }

    [Fact]
    public void RepeatCounterCheck_ForUserInputHelloGoodbye_0()
    {
      RepeatCounter repeatCounterTest = new RepeatCounter();
      Assert.Equal(0, repeatCounterTest.CounterRepeats("Hello", "Goodbye"));
    }

    [Fact]
    public void RepeatCounterCheck_ForUserInputHello_HelloGoodbye_1()
    {
      RepeatCounter repeatCounterTest = new RepeatCounter();
      Assert.Equal(1, repeatCounterTest.CounterRepeats("Hello", "Hello Goodbye"));
    }

    [Fact]
    public void RepeatCounterCheck_ForUserInputHello_HelloGoodbyeHello_2()
    {
      RepeatCounter repeatCounterTest = new RepeatCounter();
      Assert.Equal(2, repeatCounterTest.CounterRepeats("Hello", "Hello Goodbye Hello"));
    }

    [Fact]
    public void RepeatCounterCheck_ForUserInputHELLO_HerloHEllohelloHELLO_2()
    {
      RepeatCounter repeatCounterTest = new RepeatCounter();
      Assert.Equal(3, repeatCounterTest.CounterRepeats("HELLO", "Herlo HEllo hello HELLO"));
    }
  }
}
