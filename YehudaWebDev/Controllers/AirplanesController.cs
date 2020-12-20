using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YehudaWebDev.Data;
using YehudaWebDev.Models;

namespace YehudaWebDev.Controllers
{
    public class AirplanesController : Controller
    {
        private readonly YehudaWebDevContext _context;

        public AirplanesController(YehudaWebDevContext context)
        {
            _context = context;
        }

        // GET: Airplanes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Airplanes.ToListAsync());
        }

        // GET: Airplanes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplanes = await _context.Airplanes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airplanes == null)
            {
                return NotFound();
            }

            return View(airplanes);
        }

        // GET: Airplanes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Airplanes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Manufacturer,AirplaneModel,ManufactureYear,EcoeconomySeats,BusinessSeats")] Airplanes airplanes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airplanes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airplanes);
        }

        // GET: Airplanes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplanes = await _context.Airplanes.FindAsync(id);
            if (airplanes == null)
            {
                return NotFound();
            }
            return View(airplanes);
        }

        // POST: Airplanes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Manufacturer,AirplaneModel,ManufactureYear,EcoeconomySeats,BusinessSeats")] Airplanes airplanes)
        {
            if (id != airplanes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airplanes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirplanesExists(airplanes.Id))
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
            return View(airplanes);
        }

        // GET: Airplanes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airplanes = await _context.Airplanes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airplanes == null)
            {
                return NotFound();
            }

            return View(airplanes);
        }

        // POST: Airplanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var airplanes = await _context.Airplanes.FindAsync(id);
            _context.Airplanes.Remove(airplanes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirplanesExists(string id)
        {
            return _context.Airplanes.Any(e => e.Id == id);
        }
    }
}
