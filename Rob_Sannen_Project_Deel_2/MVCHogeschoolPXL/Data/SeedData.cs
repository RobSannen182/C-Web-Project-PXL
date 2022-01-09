using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCHogeschoolPXL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCHogeschoolPXL.Data
{
    public static class SeedData
    {
        public static async Task EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();
            RoleManager<IdentityRole> roleManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            await CreateRolesAsync(context, roleManager);
            UserManager<IdentityUser> userManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            await CreateIdentityRecordAsync(userManager);

            if (!context.Gebruikers.Any())
            {
                Gebruiker g = new Gebruiker { Naam = "Sannen", Voornaam = "Rob", Email = "rob@rob.be" };
                Gebruiker gg = new Gebruiker { Naam = "Palmaers", Voornaam = "Kristof", Email = "kristof.palmaers@pxl.be" };
                context.Gebruikers.AddRange(g, gg);
                context.SaveChanges();
                var gebruiker1Id = context.Gebruikers.Where(x => x.Voornaam == "Rob").Select(x => x.GebruikerId).SingleOrDefault();
                Student s = new Student { GebruikerId = gebruiker1Id };
                context.Studenten.AddRange(s);
                context.SaveChanges();
                var gebruiker2 = context.Gebruikers.Where(x => x.Voornaam == "Kristof").FirstOrDefault();
                Lector l = new Lector { GebruikerId = gebruiker2.GebruikerId };
                context.Lectoren.AddRange(l);
                context.SaveChanges();
                Handboek h = new Handboek { Titel = "C# Web 1", Kostprijs = 49.99m, UitgifteDatum = Convert.ToDateTime("10/10/2020"), Afbeelding = "CWeb1.jpg" };
                context.Handboeken.AddRange(h);
                context.SaveChanges();
                var handboek = context.Handboeken.Where(x => x.Titel == "C# Web 1").FirstOrDefault();
                Vak v = new Vak { VakNaam = "C# Web 1", Studiepunten = 15, HandboekId = handboek.HandboekId };
                context.Vakken.AddRange(v);
                context.SaveChanges();
                var vak = context.Vakken.Where(x => x.VakNaam == "C# Web 1").FirstOrDefault();
                var lector = context.Lectoren.Where(x => x.GebruikerId == gebruiker2.GebruikerId).FirstOrDefault();
                VakLector vl = new VakLector { VakId = vak.VakId, LectorId = lector.LectorId };
                context.VakLectoren.AddRange(vl);
                context.SaveChanges();
                AcademieJaar a = new AcademieJaar { StartDatum = Convert.ToDateTime("09/20/2021") };
                context.AcademieJaren.AddRange(a);
                context.SaveChanges();
                var student = context.Studenten.Where(x => x.Gebruiker.Voornaam == "Rob").FirstOrDefault();
                var vakLector = context.VakLectoren.Include(vl => vl.Lector).ThenInclude(vl => vl.Gebruiker).Where(vl => vl.Lector.Gebruiker.Naam == "Palmaers").FirstOrDefault();
                var academiejaar = context.AcademieJaren.Where(a => a.StartDatum == Convert.ToDateTime("09/20/2021")).FirstOrDefault();
                Inschrijving i = new Inschrijving { StudentId = student.StudentId, VakLectorId = vakLector.VaklectorId, AcademieJaarId = academiejaar.AcademieJaarId };
                context.Inschrijvingen.AddRange(i);
                context.SaveChanges();
            }
        }

        private static async Task CreateRolesAsync(ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            if (!context.Roles.Any())
            {
                await CreateRoleAsync(roleManager, Roles.Admin);
                await CreateRoleAsync(roleManager, Roles.Lector);
                await CreateRoleAsync(roleManager, Roles.Student);
            }
        }

        private static async Task CreateRoleAsync(RoleManager<IdentityRole> roleManager, string role)
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                IdentityRole identityRole = new IdentityRole(role);
                await roleManager.CreateAsync(identityRole);
            }
        }

        private static async Task CreateIdentityRecordAsync(UserManager<IdentityUser> userManager)
        {
            var email = "admin@pxl.be";
            var userName = email;
            if (await userManager.FindByEmailAsync(email) == null)
            {
                var pwd = "Admin456!";
                var identityUser = new IdentityUser() { Email = email, UserName = userName };
                await userManager.CreateAsync(identityUser, pwd);
                await userManager.AddToRoleAsync(identityUser, Roles.Admin);
            }
            email = "student@pxl.be";
            userName = email;
            if (await userManager.FindByEmailAsync(email) == null)
            {
                var pwd = "Student123!";
                var identityUser = new IdentityUser() { Email = email, UserName = userName };
                await userManager.CreateAsync(identityUser, pwd);
                await userManager.AddToRoleAsync(identityUser, Roles.Student);
            }
        }

        public class Roles
        {
            public const string Admin = "Admin";
            public const string Lector = "Lector";
            public const string Student = "Student";
        }
    }
}
