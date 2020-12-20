﻿using System;
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
    public class AirlinesController : Controller
    {
        private readonly YehudaWebDevContext _context;

        public AirlinesController(YehudaWebDevContext context)
        {
            _context = context;
        }

        // GET: Airlines
        public async Task<IActionResult> Index()
        {
            return View(await _context.Airlines.ToListAsync());
        }

        // GET: Airlines/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airlines = await _context.Airlines
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airlines == null)
            {
                return NotFound();
            }

            return View(airlines);
        }

        // GET: Airlines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Airlines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AirlineName,AirlineCountry,NumberOfPlanes,NumberOfWorkers,YearlyTravelerNumber,YearOfEstablishment")] Airlines airlines)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airlines);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airlines);
        }

        // GET: Airlines/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airlines = await _context.Airlines.FindAsync(id);
            if (airlines == null)
            {
                return NotFound();
            }
            return View(airlines);
        }

        // POST: Airlines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,AirlineName,AirlineCountry,NumberOfPlanes,NumberOfWorkers,YearlyTravelerNumber,YearOfEstablishment")] Airlines airlines)
        {
            if (id != airlines.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airlines);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirlinesExists(airlines.Id))
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
            return View(airlines);
        }

        // GET: Airlines/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airlines = await _context.Airlines
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airlines == null)
            {
                return NotFound();
            }

            return View(airlines);
        }

        // POST: Airlines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var airlines = await _context.Airlines.FindAsync(id);
            _context.Airlines.Remove(airlines);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirlinesExists(string id)
        {
            return _context.Airlines.Any(e => e.Id == id);
        }
    }
}
