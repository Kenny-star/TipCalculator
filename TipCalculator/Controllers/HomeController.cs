using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //Instantiates the ViewBag dictionary tip values to 0 as a starting point
            ViewBag.tip15 = 0;
            ViewBag.tip20 = 0;
            ViewBag.tip25 = 0;

            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            //If values were successfully binded to the TipCalculatorModel from the request in the view, then execute the tips calculation functions.
            if (ModelState.IsValid)
            {
                ViewBag.tip15 = model.Calculate15Tip();
                ViewBag.tip20 = model.Calculate20Tip();
                ViewBag.tip25 = model.Calculate25Tip();
            }
            else
            {
            
                ViewBag.tip15 = 0;
                ViewBag.tip20 = 0;
                ViewBag.tip25 = 0;
            }
            return View(model);
        }
    }
}
