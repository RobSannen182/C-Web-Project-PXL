using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCHogeschoolPXL.Data;
using MVCHogeschoolPXL.Models;

namespace MVCHogeschoolPXL.Controllers
{
    public class VakController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public VakController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Vak
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (await _userManager.IsInRoleAsync(user, SeedData.Roles.Lector))
            {
                var email = user.Email;
                var gebr = _context.Gebruikers.Where(g => g.Email == email).FirstOrDefault();
                var vakken = new List<Vak>();
                if (gebr != null)
                {
                    var lector = _context.Lectoren.Where(l => l.GebruikerId == gebr.GebruikerId)
                        .Include(l => l.VakLectoren)
                        .ThenInclude(vl => vl.Vak)
                        .ThenInclude(v => v.Handboek)
                        .FirstOrDefault();
                    foreach (var vakLector in lector.VakLectoren)
                    {
                        vakken.Add(vakLector.Vak);
                    }
                }
                return View(vakken);
            }
            var applicationDbContext = _context.Vakken.Include(v => v.Handboek).OrderByDescending(v => v.Studiepunten);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Vak/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vak = await _context.Vakken
                .Include(v => v.Handboek)
                .FirstOrDefaultAsync(m => m.VakId == id);
            if (vak == null)
            {
                return NotFound();
            }

            return View(vak);
        }

        // GET: Vak/Create
        [Authorize(Roles = SeedData.Roles.Admin)]
        public IActionResult Create()
        {
            if (_context.Handboeken.Count() > 0)
            {
                ViewData["HandboekId"] = new SelectList(_context.Handboeken, "HandboekId", "Titel");
                return View();
            }
            else
            {
                ViewData["Handboek"] = "noHandboek";
                return View();
            }
        }

        // POST: Vak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VakId,VakNaam,Studiepunten,HandboekId")] Vak vak)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HandboekId"] = new SelectList(_context.Handboeken, "HandboekId", "Titel", vak.HandboekId);
            return View(vak);
        }

        // GET: Vak/Edit/5
        [Authorize(Roles = SeedData.Roles.Admin)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vak = await _context.Vakken.FindAsync(id);
            if (vak == null)
            {
                return NotFound();
            }
            ViewData["HandboekId"] = new SelectList(_context.Handboeken, "HandboekId", "Titel", vak.HandboekId);
            return View(vak);
        }

        // POST: Vak/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VakId,VakNaam,Studiepunten,HandboekId")] Vak vak)
        {
            if (id != vak.VakId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VakExists(vak.VakId))
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
            ViewData["HandboekId"] = new SelectList(_context.Handboeken, "HandboekId", "Titel", vak.HandboekId);
            return View(vak);
        }

        // GET: Vak/Delete/5
        [Authorize(Roles = SeedData.Roles.Admin)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vak = await _context.Vakken
                .Include(v => v.Handboek)
                .FirstOrDefaultAsync(m => m.VakId == id);
            if (vak == null)
            {
                return NotFound();
            }

            return View(vak);
        }

        // POST: Vak/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vak = await _context.Vakken.FindAsync(id);
            _context.Vakken.Remove(vak);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VakExists(int id)
        {
            return _context.Vakken.Any(e => e.VakId == id);
        }
    }
}
