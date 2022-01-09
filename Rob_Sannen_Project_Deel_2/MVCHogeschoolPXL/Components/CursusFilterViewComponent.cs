using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCHogeschoolPXL.Data;
using MVCHogeschoolPXL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCHogeschoolPXL.Components
{
    public class CursusFilterViewComponent : ViewComponent
    {
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;

        public CursusFilterViewComponent(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["vakNaam"];

            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            if (_userManager.IsInRoleAsync(user, SeedData.Roles.Lector).Result)
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
            var vakkenList = _context.Vakken.ToList();
            return View(vakkenList);
        }
    }
}
