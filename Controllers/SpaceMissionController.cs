using MachineLearning.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachineLearning.Controllers
{
    public class SpaceMissionController : Controller
    {

        connAbby conn = new connAbby();

        [HttpGet]
        public IActionResult SpaceMissionHome()
        {
            Console.WriteLine("method reached");
            return View();
        }

        [HttpPost]
        public IActionResult SpaceMissionResultPage(SpaceMissionModel model)
        {
            Console.WriteLine("results reached");
            string prediction = conn.predictData(model.companyName, model.location, model.statusRocket, model.rocketCost);
            ViewBag.Prediction = prediction;
            return View();
        }


    }
}
