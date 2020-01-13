namespace Ibanka.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Credit> Credit { get; set; }
        public virtual DbSet<Keys> Keys { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Accounts)
                .HasForeignKey(e => e.Konta1Id)
                .WillCascadeOnDelete(false);



            modelBuilder.Entity<Users>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Keys)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
