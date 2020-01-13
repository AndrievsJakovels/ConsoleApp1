namespace MovieApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieDB : DbContext
    {
        public MovieDB()
            : base("name=MovieDB1")
        {
        }

        public virtual DbSet<Cinemas> Cinemas { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinemas>()
                .HasMany(e => e.Movies)
                .WithRequired(e => e.Cinemas)
                .HasForeignKey(e => e.CinemaId)
                .WillCascadeOnDelete(false);
        }
    }
}
