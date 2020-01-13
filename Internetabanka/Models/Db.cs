namespace Internetabanka.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Db : DbContext
    {
        public Db()
            : base("name=Db")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Credit> Credits { get; set; }
        public virtual DbSet<Key> Keys { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>()
                .HasMany(e => e.Payments1)
                .WithOptional(e => e.Payment1)
                .HasForeignKey(e => e.Konta1Id);

            modelBuilder.Entity<Payment>()
                .HasMany(e => e.Payments11)
                .WithOptional(e => e.Payment2)
                .HasForeignKey(e => e.Konta2Id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UsersId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Credits)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UsersID);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Keys)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UsersId)
                .WillCascadeOnDelete(false);
        }
    }
}
