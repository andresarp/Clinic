using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Clinica.Models;

namespace Clinica.Controllers
{
    public class SpecialtyRoomsController : Controller
    {
        private readonly ClinicContext _context;

        public SpecialtyRoomsController(ClinicContext context)
        {
            _context = context;
        }

        // GET: SpecialtyRooms
        public async Task<IActionResult> Index()
        {
              return View(await _context.Specialties.ToListAsync());
        }

        // GET: SpecialtyRooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Specialties == null)
            {
                return NotFound();
            }

            var specialtyRoom = await _context.Specialties
                .FirstOrDefaultAsync(m => m.idSpecialtyRoom == id);
            if (specialtyRoom == null)
            {
                return NotFound();
            }

            return View(specialtyRoom);
        }

        // GET: SpecialtyRooms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SpecialtyRooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idSpecialtyRoom,number,specialty")] SpecialtyRoom specialtyRoom)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specialtyRoom);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialtyRoom);
        }

        // GET: SpecialtyRooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Specialties == null)
            {
                return NotFound();
            }

            var specialtyRoom = await _context.Specialties.FindAsync(id);
            if (specialtyRoom == null)
            {
                return NotFound();
            }
            return View(specialtyRoom);
        }

        // POST: SpecialtyRooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idSpecialtyRoom,number,specialty")] SpecialtyRoom specialtyRoom)
        {
            if (id != specialtyRoom.idSpecialtyRoom)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specialtyRoom);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialtyRoomExists(specialtyRoom.idSpecialtyRoom))
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
            return View(specialtyRoom);
        }

        // GET: SpecialtyRooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Specialties == null)
            {
                return NotFound();
            }

            var specialtyRoom = await _context.Specialties
                .FirstOrDefaultAsync(m => m.idSpecialtyRoom == id);
            if (specialtyRoom == null)
            {
                return NotFound();
            }

            return View(specialtyRoom);
        }

        // POST: SpecialtyRooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Specialties == null)
            {
                return Problem("Entity set 'ClinicContext.Specialties'  is null.");
            }
            var specialtyRoom = await _context.Specialties.FindAsync(id);
            if (specialtyRoom != null)
            {
                _context.Specialties.Remove(specialtyRoom);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialtyRoomExists(int id)
        {
          return _context.Specialties.Any(e => e.idSpecialtyRoom == id);
        }
    }
}
