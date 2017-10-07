using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AIRA.UI.Controllers
{
    public class RiskManagementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MarketRisk()
        {
            return View();
        }

        public IActionResult CollateralManagement()
        {
            return View();
        }

        public IActionResult XVA()
        {
            return View();
        }
        public IActionResult CounterpartyRisk()
        {
            return View();
        }
        public IActionResult StressTesting()
        {
            return View();
        }

    }
}