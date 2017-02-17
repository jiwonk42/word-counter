using Nancy;
using RepeatCounterApp;
using System;

namespace RepeatCounterApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/result"] = _ =>
      {
        RepeatCounter counter = new RepeatCounter();
        return View["result.cshtml", counter.CounterRepeats(Request.Form["userWord"], Request.Form["userStrings"])];
      };
    }
  }
}
