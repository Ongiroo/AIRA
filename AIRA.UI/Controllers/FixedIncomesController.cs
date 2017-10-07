using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AIRA.UI.Data;
using AIRA.UI.Models;

namespace AIRA.UI.Controllers
{
    public class FixedIncomesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FixedIncomesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FixedIncomes
        public async Task<IActionResult> Index()
        {
            return View(await _context.FixedIncome.ToListAsync());
        }

        // GET: FixedIncomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixedIncome = await _context.FixedIncome
                .SingleOrDefaultAsync(m => m.Id == id);
            if (fixedIncome == null)
            {
                return NotFound();
            }

            return View(fixedIncome);
        }

        // GET: FixedIncomes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FixedIncomes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Quantity,PurchaseDate,PurchasePrice,CurrentPrice,Commission,CreditQuality,MaturityDate,Coupon,CurrencyType")] FixedIncome fixedIncome)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fixedIncome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fixedIncome);
        }

        // GET: FixedIncomes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixedIncome = await _context.FixedIncome.SingleOrDefaultAsync(m => m.Id == id);
            if (fixedIncome == null)
            {
                return NotFound();
            }
            return View(fixedIncome);
        }

        // POST: FixedIncomes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Quantity,PurchaseDate,PurchasePrice,CurrentPrice,Commission,CreditQuality,MaturityDate,Coupon,CurrencyType")] FixedIncome fixedIncome)
        {
            if (id != fixedIncome.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fixedIncome);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FixedIncomeExists(fixedIncome.Id))
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
            return View(fixedIncome);
        }

        // GET: FixedIncomes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixedIncome = await _context.FixedIncome
                .SingleOrDefaultAsync(m => m.Id == id);
            if (fixedIncome == null)
            {
                return NotFound();
            }

            return View(fixedIncome);
        }

        // POST: FixedIncomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fixedIncome = await _context.FixedIncome.SingleOrDefaultAsync(m => m.Id == id);
            _context.FixedIncome.Remove(fixedIncome);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FixedIncomeExists(int id)
        {
            return _context.FixedIncome.Any(e => e.Id == id);
        }
    }
}
