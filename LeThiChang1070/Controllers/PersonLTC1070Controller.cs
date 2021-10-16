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
    public class PersonLTC1070Controller : Controller
    {
        private readonly LeThiChang1070Context _context;

        public PersonLTC1070Controller(LeThiChang1070Context context)
        {
            _context = context;
        }

        // GET: PersonLTC1070
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonLTC1070.ToListAsync());
        }

        // GET: PersonLTC1070/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLTC1070 = await _context.PersonLTC1070
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personLTC1070 == null)
            {
                return NotFound();
            }

            return View(personLTC1070);
        }

        // GET: PersonLTC1070/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonLTC1070/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,PersonName")] PersonLTC1070 personLTC1070)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personLTC1070);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personLTC1070);
        }

        // GET: PersonLTC1070/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLTC1070 = await _context.PersonLTC1070.FindAsync(id);
            if (personLTC1070 == null)
            {
                return NotFound();
            }
            return View(personLTC1070);
        }

        // POST: PersonLTC1070/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonID,PersonName")] PersonLTC1070 personLTC1070)
        {
            if (id != personLTC1070.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personLTC1070);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonLTC1070Exists(personLTC1070.PersonID))
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
            return View(personLTC1070);
        }

        // GET: PersonLTC1070/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLTC1070 = await _context.PersonLTC1070
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personLTC1070 == null)
            {
                return NotFound();
            }

            return View(personLTC1070);
        }

        // POST: PersonLTC1070/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personLTC1070 = await _context.PersonLTC1070.FindAsync(id);
            _context.PersonLTC1070.Remove(personLTC1070);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonLTC1070Exists(int id)
        {
            return _context.PersonLTC1070.Any(e => e.PersonID == id);
        }
    }
}
