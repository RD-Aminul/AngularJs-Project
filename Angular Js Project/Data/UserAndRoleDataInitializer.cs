using Angular_Js_Project.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Data
{
    public static class UserAndRoleDataInitializer
    {
        public static void SeedData(UserManager<IdentityUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    PhoneNumber = "123456",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                };

                IdentityResult result = userManager.CreateAsync(user, "123456").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<ApplicationRole> roleManager)
        {
            IdentityResult roleResult;
            Task<bool> hasAdminRole = roleManager.RoleExistsAsync("Admin");
            hasAdminRole.Wait();
            if (!hasAdminRole.Result)
            {
                ApplicationRole role = new ApplicationRole();
                role.Name = "Admin";
                role.ControllerName = "All";
                role.ActionName = "All";
                ApplicationRole role1 = new ApplicationRole(role.Name, role.ControllerName, role.ActionName);
                roleResult = roleManager.CreateAsync(role1).Result;
            }
        }
    }
}
