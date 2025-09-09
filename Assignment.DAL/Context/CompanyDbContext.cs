using Assignment.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DAL.Context
{
    public class CompanyDbContext(DbContextOptions<CompanyDbContext> options) : DbContext(options)
    {
        DbSet<Department> Departments { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CompanyDbContext).Assembly);
        }

    }


}
