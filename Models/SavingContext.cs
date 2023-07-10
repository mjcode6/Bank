using Microsoft.EntityFrameworkCore;

namespace bank.Models
{
    public class SavingContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<SavingAccount> SavingAccount { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Database=bank;Integrated Security=sspi;Encrypt=true;TrustServerCertificate=true;");
           
        }
    }

}
