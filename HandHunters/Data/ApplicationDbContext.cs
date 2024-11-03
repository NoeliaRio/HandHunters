using HandHunters.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HandHunters.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Carta> cartas { get; set; }
        public DbSet<Calidad> calidades { get; set; }
        public DbSet<Estado> estados { get; set; }
        public DbSet<Franquicia> franquicias { get; set; }
        public DbSet<Idioma> idiomas { get; set; }

    }

}
