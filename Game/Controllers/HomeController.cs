using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {

    [Route("/input")]
    public ActionResult Input() { return View(); }

    [Route("/output")]
    public ActionResult Output(string input1, string input2)
    {
      ProjectVariable myProjectVariable = new ProjectVariable();
      myProjectVariable.SetInput1(input1);
      myProjectVariable.SetInput2(input2);
      return View(myProjectVariable);
    }

  }
}
