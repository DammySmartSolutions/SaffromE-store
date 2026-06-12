using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaffromEstore.DataAccess.Data
{
   
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer(
                "Server=OLUWADAMILOLA;Database=SaffromEcommerce;User Id=sa;Password=Manchester43;TrustServerCertificate=True"
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
