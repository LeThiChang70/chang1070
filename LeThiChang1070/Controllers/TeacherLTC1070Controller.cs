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
    public class TeacherLTC1070Controller : Controller
    {
        private readonly LeThiChang1070Context _context;

        public TeacherLTC1070Controller(LeThiChang1070Context context)
        {
            _context = context;
        }

        // GET: TeacherLTC1070
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeacherLTC1070.ToListAsync());
        }

        // GET: TeacherLTC1070/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherLTC1070 = await _context.TeacherLTC1070
                .FirstOrDefaultAsync(m => m.TeacherID == id);
            if (teacherLTC1070 == null)
            {
                return NotFound();
            }

            return View(teacherLTC1070);
        }

        // GET: TeacherLTC1070/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TeacherLTC1070/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherID,TeacherName")] TeacherLTC1070 teacherLTC1070)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teacherLTC1070);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teacherLTC1070);
        }

        // GET: TeacherLTC1070/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherLTC1070 = await _context.TeacherLTC1070.FindAsync(id);
            if (teacherLTC1070 == null)
            {
                return NotFound();
            }
            return View(teacherLTC1070);
        }

        // POST: TeacherLTC1070/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeacherID,TeacherName")] TeacherLTC1070 teacherLTC1070)
        {
            if (id != teacherLTC1070.TeacherID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teacherLTC1070);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeacherLTC1070Exists(teacherLTC1070.TeacherID))
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
            return View(teacherLTC1070);
        }

        // GET: TeacherLTC1070/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacherLTC1070 = await _context.TeacherLTC1070
                .FirstOrDefaultAsync(m => m.TeacherID == id);
            if (teacherLTC1070 == null)
            {
                return NotFound();
            }

            return View(teacherLTC1070);
        }

        // POST: TeacherLTC1070/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teacherLTC1070 = await _context.TeacherLTC1070.FindAsync(id);
            _context.TeacherLTC1070.Remove(teacherLTC1070);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeacherLTC1070Exists(int id)
        {
            return _context.TeacherLTC1070.Any(e => e.TeacherID == id);
        }
    }
}
