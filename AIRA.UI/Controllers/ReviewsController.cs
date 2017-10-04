using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AIRA.UI.Data;

namespace AIRA.UI.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IActionResult Index([Bind(Prefix ="id")] int portfolioId)
        {
            var portfolio = _context.Portfolio.Find(portfolioId);
            if(portfolio != null)
            {
                return View(portfolio);
            }
            return View("404 error!");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }
}