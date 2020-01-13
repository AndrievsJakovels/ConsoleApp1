namespace MoviesApp4Logic.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=MovieDB")
        {
        }

        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>()
                .HasMany(e => e.Movies)
                .WithRequired(e => e.Cinema)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movies>()
                .HasMany(e => e.Sessions)
                .WithOptional(e => e.Movy)
                .HasForeignKey(e => e.MovieId);
        }
    }
}
