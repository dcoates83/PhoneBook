using Microsoft.EntityFrameworkCore;
using PhoneBookApp.Models;

namespace PhoneBookApp.Data
{
    public class PhoneBookContext : DbContext
    {
        private readonly string _connectionString;
        public required DbSet<Contact> Contacts { get; set; }
        public PhoneBookContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}