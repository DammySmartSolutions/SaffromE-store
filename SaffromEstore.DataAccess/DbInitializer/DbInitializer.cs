using SaffromEstore.Models;
using SaffromEstore.Utility;
using SaffromEstore.DataAccess.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaffromEstore.DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;

        public DbInitializer(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db
            )
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }

        public async Task InitializeAsync()
        {
            try
            {
                if ((await _db.Database.GetPendingMigrationsAsync()).Any())
                {
                    await _db.Database.MigrateAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }


            if (!await _roleManager.RoleExistsAsync(SD.RoleCustomer))
            {
                await _roleManager.CreateAsync(new IdentityRole(SD.RoleCustomer));
                await _roleManager.CreateAsync(new IdentityRole(SD.RoleAdmin));
                await _roleManager.CreateAsync(new IdentityRole(SD.RoleEmployee));
            }

            ApplicationUser user = await _userManager.FindByEmailAsync("saffromadmin@gmail.com");
            if (user == null)
            {
                var result = await _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "saffromadmin@gmail.com",
                    Email = "saffromadmin@gmail.com",
                    EmailConfirmed = true,
                    Name = "Saffrom Admin",
                    PhoneNumber = "7093512345",
                    StreetAddress = "123 test",
                    State = "NL",
                    PostalCode = "A1A 1A1",
                    City = "John's"
                }, "Admin@1234");

                if (result.Succeeded)
                {
                    user = await _userManager.FindByEmailAsync("saffromadmin@gmail.com");
                    await _userManager.AddToRoleAsync(user, SD.RoleAdmin);
                }
            }

        }
    }
}
