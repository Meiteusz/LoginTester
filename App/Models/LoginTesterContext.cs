using Microsoft.EntityFrameworkCore;

namespace Models
{
    public class LoginTesterContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-KQ43TMP\SQLEXPRESS;Initial Catalog=LoginTester;Integrated Security=True");
        }
    }
}
