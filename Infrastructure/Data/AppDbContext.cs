using HexagonalCrud.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HexagonalCrud.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Client> Clients => Set<Client>();
    }
    
}

