using System;
using System.IO;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.Json;
using Mijalski.EntityFrameworkCore;

namespace Mijalski.GraphicCardCompare
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }
        public IConfiguration Configuration { get; set; }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            var configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName)
                .AddJsonFile("appsettings.json")
                .Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
 
            ServiceProvider = serviceCollection.BuildServiceProvider();
 
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
 
        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(MainWindow));
            var x = Configuration.GetConnectionString("DefaultConnection");
            var x2 = Configuration.GetSection("ConnectionStrings");
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")
                )
            );
        }
    }
}
