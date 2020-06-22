using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFinances.Database.Models;

namespace MyFinances.Database.Context
{
    public class MyFinancesContext : IdentityDbContext
    {
        public MyFinancesContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<FavorityAsset> FavorityAssets { get; set; }
    }
}
