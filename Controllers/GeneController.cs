
using MachineLearning.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachineLearning.Controllers
{
    public class GeneController : Controller
    {
        GeneClassification g = new GeneClassification();
        [HttpGet]
        public IActionResult CancerModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GeneResult(Cancer c)
        {
            string prediction = g.DataClassification(c.Gene_Description, c.Gene_Accession_Number, c.Call).ToString();
            ViewBag.Prediction = prediction;
            return View();
        }
    }
}
