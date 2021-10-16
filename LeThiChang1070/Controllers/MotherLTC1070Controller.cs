using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeThiChang1070.Data;
using LeThiChang1070.Models;

namespace LeThiChang1070.Controllers
{
    public class MotherLTC1070Controller : Controller
    {
        private readonly LeThiChang1070Context _context;

        public MotherLTC1070Controller(LeThiChang1070Context context)
        {
            _context = context;
        }

        // GET: MotherLTC1070
        public async Task<IActionResult> Index()
        {
            return View(await _context.MotherLTC1070.ToListAsync());
        }

        // GET: MotherLTC1070/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motherLTC1070 = await _context.MotherLTC1070
                .FirstOrDefaultAsync(m => m.MotherID == id);
            if (motherLTC1070 == null)
            {
                return NotFound();
            }

            return View(motherLTC1070);
        }

        // GET: MotherLTC1070/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MotherLTC1070/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MotherID,MotherName")] MotherLTC1070 motherLTC1070)
        {
            if (ModelState.IsValid)
            {
                _context.Add(motherLTC1070);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(motherLTC1070);
        }

        // GET: MotherLTC1070/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motherLTC1070 = await _context.MotherLTC1070.FindAsync(id);
            if (motherLTC1070 == null)
            {
                return NotFound();
            }
            return View(motherLTC1070);
        }

        // POST: MotherLTC1070/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MotherID,MotherName")] MotherLTC1070 motherLTC1070)
        {
            if (id != motherLTC1070.MotherID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(motherLTC1070);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MotherLTC1070Exists(motherLTC1070.MotherID))
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
            return View(motherLTC1070);
        }

        // GET: MotherLTC1070/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var motherLTC1070 = await _context.MotherLTC1070
                .FirstOrDefaultAsync(m => m.MotherID == id);
            if (motherLTC1070 == null)
            {
                return NotFound();
            }

            return View(motherLTC1070);
        }

        // POST: MotherLTC1070/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var motherLTC1070 = await _context.MotherLTC1070.FindAsync(id);
            _context.MotherLTC1070.Remove(motherLTC1070);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MotherLTC1070Exists(string id)
        {
            return _context.MotherLTC1070.Any(e => e.MotherID == id);
        }
    }
}
