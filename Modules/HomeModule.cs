using Nancy;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var leetSpeak = new LeetSpeak();
        var leetString = leetSpeak.Translate("");
        return View["index.cshtml", leetString];
      };
      Post["/speak"] = _ => {
        var inputString = Request.Form["user-string"];
        var leetSpeak = new LeetSpeak();
        var leetString = leetSpeak.Translate(inputString);
        return View["index.cshtml", leetString];
      };
    }
  }
}
