using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MDSnkeakShop.Data
{
    public static class DBContextOptions
    {
         public static DbContextOptionsBuilder UseMySqlConfiguration(this DbContextOptionsBuilder optionsBuilder)
        {
            return optionsBuilder.UseMySql("server=localhost;database=MDSnkeakShopDBA;user=adminuser;password=securepassword123",
                new MySqlServerVersion(new Version(8, 0, 25)));
        }
    }
}