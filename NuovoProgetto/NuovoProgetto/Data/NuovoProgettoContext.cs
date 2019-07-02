using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuovoProgetto.Models;
using Microsoft.EntityFrameworkCore;

namespace NuovoProgetto.Models
{
    public class NuovoProgettoContext : DbContext
    {
        public NuovoProgettoContext (DbContextOptions<NuovoProgettoContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='Nuovo database';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
