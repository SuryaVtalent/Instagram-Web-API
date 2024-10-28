using InstagramProject.Models;
using Microsoft.EntityFrameworkCore;

namespace InstagramProject.DataContext
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options) { }

        public DbSet<Instaparent> Instaparents { get; set; }
        public DbSet<Instachild> Instachilds { get; set; }

    }
}
