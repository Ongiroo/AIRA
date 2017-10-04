using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AIRA.UI.Data;
using AIRA.UI.Models;
using Microsoft.AspNetCore.Authorization;
using AIRA.UI.Models.PortfolioViewModels;

namespace AIRA.UI.Controllers
{
    public class PortfoliosController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public PortfoliosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Portfolios
        public async Task<Microsoft.AspNetCore.Mvc.IActionResult> Index()
        {     
                
            return View(await _context.Portfolio.ToListAsync());
        }
        
        [HttpGet]
        [AllowAnonymous]
        [ActionName("IndexWithSearch")]
        public IActionResult Index(string searchTerm = null)
        {
            var model = _context.Portfolio
                .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))
                .Take(10)
                .Select(r => new PortfolioListViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    ReturnAttribution = r.ReturnAttribution,
                    RiskAttribution = r.RiskAttribution,
                    CountOfReviews = r.Reviews.Count()
                });

            return View(model);
        }
        // GET: Portfolios/Details/5
        public async Task<Microsoft.AspNetCore.Mvc.IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio
                .SingleOrDefaultAsync(m => m.Id == id);
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // GET: Portfolios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Portfolios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<Microsoft.AspNetCore.Mvc.IActionResult> Create([Bind("Id,Name,ReturnAttribution,RiskAttribution,Title,Sector")] Models.Portfolio portfolio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(portfolio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(portfolio);
        }

        // GET: Portfolios/Edit/5
        public async Task<Microsoft.AspNetCore.Mvc.IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio.SingleOrDefaultAsync(m => m.Id == id);
            if (portfolio == null)
            {
                return NotFound();
            }
            return View(portfolio);
        }

        // POST: Portfolios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<Microsoft.AspNetCore.Mvc.IActionResult> Edit(int id, [Bind("Id,Name,ReturnAttribution,RiskAttribution,Title,Sector")] Models.Portfolio portfolio)
        {
            if (id != portfolio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(portfolio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PortfolioExists(portfolio.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(portfolio);
        }

        // GET: Portfolios/Delete/5
        public async Task<Microsoft.AspNetCore.Mvc.IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio
                .SingleOrDefaultAsync(m => m.Id == id);
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // POST: Portfolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteConfirmed(int id)
        {
            var portfolio = await _context.Portfolio.SingleOrDefaultAsync(m => m.Id == id);
            _context.Portfolio.Remove(portfolio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PortfolioExists(int id)
        {
            return _context.Portfolio.Any(e => e.Id == id);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
