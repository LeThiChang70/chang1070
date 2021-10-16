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
    public class DoctorLTC1070Controller : Controller
    {
        private readonly LeThiChang1070Context _context;

        public DoctorLTC1070Controller(LeThiChang1070Context context)
        {
            _context = context;
        }

        // GET: DoctorLTC1070
        public async Task<IActionResult> Index()
        {
            return View(await _context.DoctorLTC1070.ToListAsync());
        }

        // GET: DoctorLTC1070/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorLTC1070 = await _context.DoctorLTC1070
                .FirstOrDefaultAsync(m => m.DortorID == id);
            if (doctorLTC1070 == null)
            {
                return NotFound();
            }

            return View(doctorLTC1070);
        }

        // GET: DoctorLTC1070/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DoctorLTC1070/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DortorID,DoctorName")] DoctorLTC1070 doctorLTC1070)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctorLTC1070);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doctorLTC1070);
        }

        // GET: DoctorLTC1070/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorLTC1070 = await _context.DoctorLTC1070.FindAsync(id);
            if (doctorLTC1070 == null)
            {
                return NotFound();
            }
            return View(doctorLTC1070);
        }

        // POST: DoctorLTC1070/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DortorID,DoctorName")] DoctorLTC1070 doctorLTC1070)
        {
            if (id != doctorLTC1070.DortorID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctorLTC1070);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorLTC1070Exists(doctorLTC1070.DortorID))
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
            return View(doctorLTC1070);
        }

        // GET: DoctorLTC1070/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doctorLTC1070 = await _context.DoctorLTC1070
                .FirstOrDefaultAsync(m => m.DortorID == id);
            if (doctorLTC1070 == null)
            {
                return NotFound();
            }

            return View(doctorLTC1070);
        }

        // POST: DoctorLTC1070/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctorLTC1070 = await _context.DoctorLTC1070.FindAsync(id);
            _context.DoctorLTC1070.Remove(doctorLTC1070);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorLTC1070Exists(int id)
        {
            return _context.DoctorLTC1070.Any(e => e.DortorID == id);
        }
    }
}
