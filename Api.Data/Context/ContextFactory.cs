using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        IConfiguration configuration;
        public MyContext CreateDbContext(string[] args)
        {
            //var conn = "";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            //optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"));
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new MyContext(optionsBuilder.Options);
        }
    }
}
