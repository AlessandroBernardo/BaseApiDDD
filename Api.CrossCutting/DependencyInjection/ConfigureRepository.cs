using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Data.Implementations;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependeciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();


            serviceCollection.AddDbContext<MyContext>(
                options =>
                {
                    options.UseSqlServer("Data Source=DESKTOP-I5FIN5A;Initial Catalog=CursoCoreApi; Integrated Security=True;");
                });


            //serviceCollection.AddDbContext<MyContext>(
            //    options =>
            //    {
            //        try
            //        {
            //            options.UseSqlServer("Data Source=DESKTOP-I5FIN5A;Initial Catalog=CursoCoreApi; Integrated Security=True;");
            //        }
            //        catch (System.Exception)
            //        {
            //            options.UseInMemoryDatabase();
            //        }        

            //    }
            //);

        }
    }
}
