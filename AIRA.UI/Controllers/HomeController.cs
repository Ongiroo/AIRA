using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AIRA.UI.Models;
using Microsoft.AspNetCore.Authorization;
using AIRA.UI.Data;

namespace AIRA.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public IActionResult Index()
        {
            return View();
        }

        // Home/About
        public IActionResult About()
        {
            var model = new AboutModel();
            model.Name = "AIRA is an investor toolbox for the valuation of financial companies and insurance using fundamental analysis, portfolio analysis, and stress testing measures.";
            model.Location = "Dublin, Ireland";
            model.Phone = 00353876405237;
            model.Email = "amgalan.amg@gmail.com";
            return View(model);
        }
        // Home/News
        public ActionResult News([Bind(Prefix = "id")]int newsId)
        {
            var news =
                from r in _db.News
                orderby r.NewsId ascending
                select r;
            //var news = _db.News.Find(newsId);
            if (news != null)
            {
                return View(news);
            }
            return HttpNotFound();

        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        protected override void Dispose(bool disposing)
        {           
            base.Dispose(disposing);
        }
    }
}
