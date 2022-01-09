using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCHogeschoolPXL.Data;
using MVCHogeschoolPXL.Models;

namespace MVCHogeschoolPXL.Controllers
{
    public class HandboekController : Controller
    {
        private IWebHostEnvironment _environment;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public HandboekController(ApplicationDbContext context, IWebHostEnvironment environment, UserManager<IdentityUser> userManager)
        {
            _environment = environment;
            _context = context;
            _userManager = userManager;
        }

        // GET: Handboek
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (await _userManager.IsInRoleAsync(user, SeedData.Roles.Lector))
            {
                var email = user.Email;
                var gebr = _context.Gebruikers.Where(g => g.Email == email).FirstOrDefault();
                var handboeken = new List<Handboek>();
                if (gebr != null)
                {
                    var lector = _context.Lectoren.Where(l => l.GebruikerId == gebr.GebruikerId).Include(l => l.VakLectoren).ThenInclude(vl => vl.Vak).ThenInclude(v => v.Handboek).FirstOrDefault();
                    foreach (var vakLector in lector.VakLectoren)
                    {
                        handboeken.Add(vakLector.Vak.Handboek);
                    }
                }
                return View(handboeken);
            }
            return View(await _context.Handboeken.OrderBy(h => h.Titel).ToListAsync());
        }




        // GET: Handboek/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var handboek = await _context.Handboeken
                .FirstOrDefaultAsync(m => m.HandboekId == id);
            if (handboek == null)
            {
                return NotFound();
            }
            // _environment is een IWebHostEnvironment => initialiseren in ctor
            if (handboek.Afbeelding != null)
            {
                var path = _environment.WebRootPath;
                var file = Path.Combine($"{path}\\images", handboek.Afbeelding);
                var fileExist = System.IO.File.Exists(file);
                ViewBag.FileExist = fileExist;
            }
            return View(handboek);
        }

        // GET: Handboek/Create
        [Authorize(Roles = SeedData.Roles.Admin)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Handboek/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HandboekId,Titel,Kostprijs,UitgifteDatum,Afbeelding")] Handboek handboek)
        {
            if (ModelState.IsValid)
            {
                _context.Add(handboek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(handboek);
        }

        // GET: Handboek/Edit/5
        [Authorize(Roles = SeedData.Roles.Admin)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var handboek = await _context.Handboeken.FindAsync(id);
            if (handboek == null)
            {
                return NotFound();
            }
            return View(handboek);
        }

        // POST: Handboek/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HandboekId,Titel,Kostprijs,UitgifteDatum,Afbeelding")] Handboek handboek)
        {
            if (id != handboek.HandboekId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(handboek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HandboekExists(handboek.HandboekId))
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
            return View(handboek);
        }

        // GET: Handboek/Delete/5
        [Authorize(Roles = SeedData.Roles.Admin)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var handboek = await _context.Handboeken
                .FirstOrDefaultAsync(m => m.HandboekId == id);
            if (handboek == null)
            {
                return NotFound();
            }
            if (handboek.Afbeelding != null)
            {
                var path = _environment.WebRootPath;
                var file = Path.Combine($"{path}\\images", handboek.Afbeelding);
                var fileExist = System.IO.File.Exists(file);
                ViewBag.FileExist = fileExist;
            }
            return View(handboek);
        }

        // POST: Handboek/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var handboek = await _context.Handboeken.FindAsync(id);
            _context.Handboeken.Remove(handboek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HandboekExists(int id)
        {
            return _context.Handboeken.Any(e => e.HandboekId == id);
        }
    }
}
