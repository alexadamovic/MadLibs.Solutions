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
      myWords.MadLib = $"Today I went to the zoo. I saw a {adjective1} {noun1} jumping up and down in its tree. He {verbPastTense1} {adverb1} through the large tunnel that led to its {adjective2} {noun2}. I got some peanuts and passed them through the cage to a gigantic gray @Model.Noun3 towering above my head. Feeding that animal made me hungry. I went to get a @Model.Adjective3 scoop of ice cream. It filled my stomach. Afterwards I had to @Model.Verb @Model.Adverb2 to catch our bus. When I got home I @Model.VerbPastTense2 my mom for a @Model.Adjective4 day at the zoo.";
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