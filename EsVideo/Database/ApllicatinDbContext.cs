using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using EsVideo.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace EsVideo.Database
{
    public class ApllicatinDbContext : DbContext
    {
        public List<string> Generi { get; set; } = new List<string>();

        List<Libro> libri = new List<Libro> { };
        public ApllicatinDbContext(DbContextOptions<ApllicatinDbContext> options)
            : base(options)
        {
        }
        public DbSet<Libro> SetLibri { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
                var lines = System.IO.File.ReadAllLines("books.csv");
                var allBooks = lines.Skip(1)
                                    .Select(line => line.Split(';'))
                                    .Select(parts => new Libro
                                    {
                                        Titolo = parts[0],
                                        Autore = parts[1],
                                        Genere = parts[2],
                                        ISBN = parts[3],
                                        Anno = parts[4]
                                    })
                                    .ToList();
                 Generi = allBooks.Select(b => b.Genere).Distinct().OrderBy(g => g).ToList();
                 libri = allBooks;
            for (int i = 0; i < libri.Count; i++) {
                modelBuilder.Entity<Libro>().HasData(new Libro
                {
                    Titolo = libri[i].Titolo,
                    Autore = libri[i].Autore,
                    Genere = libri[i].Genere,
                    ISBN = libri[i].ISBN,
                    Anno = libri[i].Anno
                });
            }

         
        }
            
            
        
    }
}
