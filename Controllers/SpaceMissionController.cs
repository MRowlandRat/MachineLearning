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
            return View();
        }

        [HttpPost]
        public IActionResult SpaceMissionResultPage(SpaceMissionModel model)
        {
            string prediction = conn.predictData(model.CompanyName, model.Location, model.StatusRocket, model.RocketCost);
            ViewBag.Prediction = prediction;
            return View();
        }


    }
}
