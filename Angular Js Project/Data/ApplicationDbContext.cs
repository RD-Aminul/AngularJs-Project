using Angular_Js_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Angular_Js_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Train> Trains { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Passsenger> Passengers { get; set; }
    }
}
