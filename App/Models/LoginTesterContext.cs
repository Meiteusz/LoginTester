using Microsoft.EntityFrameworkCore;
using System;

namespace Models
{
    public class LoginTesterContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-KQ43TMP\SQLEXPRESS;Initial Catalog=LoginTester;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //implementing... - Shadow Properties

            //modelBuilder.Entity<User>().Property<DateTime>("CreatedDate");
            //modelBuilder.Entity<User>().Property<DateTime>("UpdatedDate");
            //
            //modelBuilder.Entity<User>().Property<long>("CreatedUser");
            //modelBuilder.Entity<User>().Property<long>("UpdatedUser");
        }
    }
}
