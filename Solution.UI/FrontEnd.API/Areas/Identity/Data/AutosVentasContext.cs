using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.API.Areas.Identity.Data;
using FrontEnd.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FrontEnd.API.Data
{
    public class AutosVentasContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<AspNetUsers> Users { get; set; }
        public DbSet<Autos> Autos { get; set; }
        public DbSet<Combustible> Combustible { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<Modelos> Modelos { get; set; }
        public DbSet<TiposAutos> TiposAutos { get; set; }
        public DbSet<Transmisiones> Transmisiones { get; set; }
        public AutosVentasContext(DbContextOptions<AutosVentasContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
