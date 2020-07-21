using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/MadlibsForms")]
    public ActionResult MadlibsForms() { return View(); }

    [Route("/Madlibs")]
    public ActionResult Madlibs(string firstname, string firstnoun) 
    {
      WordVariable myWordVariable = new WordVariable();
      myWordVariable.FirstName = firstname;
      myWordVariable.FirstNoun = firstnoun;
      return View(myWordVariable);
    }
  }
}