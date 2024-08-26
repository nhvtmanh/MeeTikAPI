using MeeTikAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MeeTikAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        #region DbSets
        public DbSet<User> Users { get; set; }
        #endregion
    }
}
