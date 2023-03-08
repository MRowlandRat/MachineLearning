
using MachineLearning.Models;
using Microsoft.AspNetCore.Mvc;
using System;


namespace MachineLearning.Controllers
{
    public class Destiny2Controller : Controller
    {
        Destiny2 c = new Destiny2();

        [HttpGet]
        public IActionResult Destiny2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Destiny2_Predictions(D2Guns gun)
        {


            string prediction = c.destiny2Predictions(gun.Gun_name, gun.Gun_archtype, gun.Source, gun.Element, gun.Gun_Rof, gun.Weapon_type);
            ViewBag.prediction = prediction;

            return View();
        }

    }
}
