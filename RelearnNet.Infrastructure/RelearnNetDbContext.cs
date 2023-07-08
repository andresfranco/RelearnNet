using Microsoft.EntityFrameworkCore;
using RelearnNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelearnNet.Infrastructure
{
    public class RelearnNetDbContext :DbContext
    {
        public RelearnNetDbContext(DbContextOptions<RelearnNetDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One to many Member and Rentals
            modelBuilder.Entity<Member>()
                .HasOne(m => m.Rental)
                .WithMany(r => r.Members)
                .HasForeignKey(m => m.RentalId);

            //Many to many Rental and Movie
            modelBuilder.Entity<MovieRental>()
                .HasKey(mr => new { mr.MovieId, mr.RentalId });

            //Handle decimals to avoid precision loss in Rental and Movie
            modelBuilder.Entity<Rental>()
                .Property(m => m.TotalCost)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Movie>()
                .Property(m => m.RentalCost)
                .HasColumnType("decimal(18,2)");
       

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }


    }
}
