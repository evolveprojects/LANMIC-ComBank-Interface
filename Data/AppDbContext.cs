using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LANMIC_ComBank_Interface.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace LANMIC_ComBank_Interface.Data
{
    public class AppDbContext : DbContext
    {
        // Table mappings
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<FormDetails> FormDetails { get; set; }
        public DbSet<SageAPICredentials> SageAPICredentials { get; set; }

        private readonly string _connectionString;

        public AppDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
