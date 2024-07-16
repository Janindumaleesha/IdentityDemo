using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityDemo.Models
{
    public class AddDbContext : IdentityDbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) 
        {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = "Data Source=DESKTOP-I46N7EU\\SQLEXPRESS;Initial Catalog=IdentityDb;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
