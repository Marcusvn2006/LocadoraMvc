using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LocadoraMVC.Models;

namespace LocadoraMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LocadoraMVC.Models.Patio> Patio { get; set; } = default!;
        public DbSet<LocadoraMVC.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<LocadoraMVC.Models.Locacao> Locacao { get; set; } = default!;
        public DbSet<LocadoraMVC.Models.Veiculo> Veiculo { get; set; } = default!;
    }
}
