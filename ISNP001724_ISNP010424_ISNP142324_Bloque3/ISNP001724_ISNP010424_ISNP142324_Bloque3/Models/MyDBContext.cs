using Microsoft.EntityFrameworkCore;
namespace ISNP001724_ISNP010424_ISNP142324_Bloque3.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

    public DbSet<pelicula> peliculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<pelicula>().HasKey(pelicula => pelicula.idPelicula);

        }
    }
}
