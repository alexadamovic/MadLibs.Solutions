using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home()
    {
      return View();
    }

    [Route("/madlibform")]
    public ActionResult MadlibForm()
    {
      return View();
    }

    [Route("/madlib")]
    public ActionResult Madlib(string adjective1, string adjective2, string adjective3, string adjective4, string noun1, string noun2, string noun3, string adverb1, string adverb2, string verb, string verbPastTense1, string verbPastTense2)
    {
      MadLibWords myWords = new MadLibWords();
      myWords.Adjective1 = adjective1;
      myWords.Adjective2 = adjective2;
      myWords.Adjective3 = adjective3;
      myWords.Adjective4 = adjective4;
      myWords.Noun1 = noun1;
      myWords.Noun2 = noun2;
      myWords.Noun3 = noun3;
      myWords.Adverb1 = adverb1;
      myWords.Adverb2 = adverb2;
      myWords.Verb = verb;
      myWords.VerbPastTense1 = verbPastTense1;
      myWords.VerbPastTense2 = verbPastTense2;
      return View(myWords);
    }
  }
}