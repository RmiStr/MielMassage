using Microsoft.EntityFrameworkCore;
using MielMassage.Models;

namespace MielMassage.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Rdv> Rdvs { get; set; }



    }
}
