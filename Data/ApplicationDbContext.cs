using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Paw_Day_Care.Models;

namespace Paw_Day_Care.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Paw_Day_Care.Models.User> User { get; set; } = default!;
        public DbSet<Paw_Day_Care.Models.Booking> Booking { get; set; } = default!;
        public DbSet<Paw_Day_Care.Models.PetSitter> PetSitter { get; set; } = default!;
        public DbSet<Paw_Day_Care.Models.Rating> Rating { get; set; } = default!;
    }
}
