using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MOCKAPP.Server.Model;
using System.Collections.Generic;

namespace MOCKAPP.Server.Data
{
    public class Dbcontext :  IdentityDbContext<ApplicationUser>
    {

        public Dbcontext(DbContextOptions<Dbcontext> options) : base(options)
        {
         
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<coursetype> coursetype { get; set; }
        public DbSet<course> course { get; set; }
        public DbSet<section> section { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Paper> Paper { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
    }
}
