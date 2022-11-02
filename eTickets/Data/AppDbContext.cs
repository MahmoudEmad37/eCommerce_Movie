using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.actorId,
                am.movieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.movie).WithMany(am => am.actors_movies)
                .HasForeignKey(m => m.movieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.actor).WithMany(am => am.actors_movies)
                .HasForeignKey(m => m.actorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
        
    }
}
