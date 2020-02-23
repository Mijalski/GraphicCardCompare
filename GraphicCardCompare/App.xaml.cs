using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using ApplicationLogic.Business.GraphicCards;
using ApplicationLogic.Generics.AppServices;
using ApplicationLogic.Generics.CommandServices;
using ApplicationLogic.Generics.QueryServices;
using ApplicationLogic.IGenerics.AppServices;
using ApplicationLogic.IGenerics.CommandServices;
using ApplicationLogic.IGenerics.QueryServices;
using AutoMapper;
using DomainLogic.Business.GraphicCards;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.Json;
using Mijalski.EntityFrameworkCore;
using Mijalski.EntityFrameworkCore.Generics;
using Mijalski.EntityFrameworkCore.IGenerics;

namespace Mijalski.GraphicCardCompare
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }
        public IConfiguration Configuration { get; set; }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName)
                .AddJsonFile("appsettings.json");
 
            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();
 
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
 
        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(MainWindow));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped(typeof(IQueryService<,>), typeof(QueryService<,>));
            services.AddScoped(typeof(ICreateCommandService<,>), typeof(CreateCommandService<,>));
            services.AddScoped(typeof(IUpdateCommandService<,>), typeof(UpdateCommandService<,>));
            services.AddScoped(typeof(IDeleteCommandService<,>), typeof(DeleteCommandService<,>));
            services.AddScoped(typeof(IAppService<,>), typeof(AppService<,>));

            services.AddScoped<IAppService<GraphicCard, GraphicCardDto>, GraphicCardAppService>();

            services.AddDbContext<DatabaseContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")
                    )
                ); 
        }
    }
}
