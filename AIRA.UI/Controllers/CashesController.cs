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
    public class CashesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CashesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cashes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cash.ToListAsync());
        }

        // GET: Cashes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cash = await _context.Cash
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cash == null)
            {
                return NotFound();
            }

            return View(cash);
        }

        // GET: Cashes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cashes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,TotalAmount,Date,CurrencyType")] Cash cash)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cash);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cash);
        }

        // GET: Cashes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cash = await _context.Cash.SingleOrDefaultAsync(m => m.Id == id);
            if (cash == null)
            {
                return NotFound();
            }
            return View(cash);
        }

        // POST: Cashes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,TotalAmount,Date,CurrencyType")] Cash cash)
        {
            if (id != cash.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cash);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CashExists(cash.Id))
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
            return View(cash);
        }

        // GET: Cashes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cash = await _context.Cash
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cash == null)
            {
                return NotFound();
            }

            return View(cash);
        }

        // POST: Cashes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cash = await _context.Cash.SingleOrDefaultAsync(m => m.Id == id);
            _context.Cash.Remove(cash);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CashExists(int id)
        {
            return _context.Cash.Any(e => e.Id == id);
        }
    }
}
