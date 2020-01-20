using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        //IConfiguration configuration;
        public MyContext CreateDbContext(string[] args)
        {

            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();

            var conn = "Data Source=DESKTOP-I5FIN5A;Initial Catalog=CursoCoreApi; Integrated Security=True;";

            //var strCon = optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            optionsBuilder.UseSqlServer(conn);

            return new MyContext(optionsBuilder.Options);
        }
    }
}
