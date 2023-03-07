using MachineLearning.Models;
using Microsoft.AspNetCore.Mvc;

namespace MachineLearning.Controllers
{
    public class SalaryController : Controller
    {

        MLMMichaelConn m = new MLMMichaelConn();

        [HttpGet]
        public IActionResult Salary()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Salary_Prediction(person p)
        {
            string prediction = m.prediction(p.YearsOfExperience, p.Title, p.Company, p.Location, p.YearsAtCompany).ToString();
            
            
            ViewBag.prediction = prediction;

            return View();
        }
    }
}
