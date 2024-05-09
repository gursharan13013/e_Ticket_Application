using e_Ticket_Application.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace e_Ticket_Application.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(am => am.ActorId);


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Movie> Movies { get; set; }
       public DbSet<Cinema> Cinemas { get; set; }
       public DbSet<Producer> Producers { get; set; }
       public DbSet<Actor> Actors { get; set; }
       public DbSet<Actor_Movie> Actors_Movies { get; set; }

    }
}
