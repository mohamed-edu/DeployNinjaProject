using Microsoft.AspNetCore.Mvc;
using DeployNinjaProject.Models;

namespace DeployNinjaProject.Controllers
{
    public class CircleController : Controller
    {
        public ActionResult Index() 
        { 
            return View(); 
        }
        [HttpPost]
        public ActionResult Calculate(double radius)
        {
            var model = new Circle { Radius = radius };

            ViewBag.Circumference = model.GetCircumference();

            ViewBag.Area = model.GetArea();

            return View("Index", model);
        }
    }
}
