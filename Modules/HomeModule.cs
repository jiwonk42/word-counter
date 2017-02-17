using Nancy;
using RepeatCounterApp;
using System;

namespace RepeatCounterApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      View["index.cshtml"];

    }
  }
}
