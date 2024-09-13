using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MDSnkeakShop.Data;
namespace YourNamespace.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
    {
        public MyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseMySql("server=localhost;database=MDSnkeakShopDBA;user=adminuser;password=securepassword123",
                new MySqlServerVersion(new Version(8, 0, 25)));

            return new MyDbContext(optionsBuilder.Options);
        }
    }
}
