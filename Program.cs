using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestProj.Data;

namespace TestProj
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var servicesProvider = new ServiceCollection().AddDbContext<MyDbContext>(options => options.UseSqlServer("Server=DBSRV\\GLO2024; Database=1var_Fortuna; Integrated Security=true; TrustServerCertificate=true")).BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var dbContext = servicesProvider.GetService<MyDbContext>();

            Application.Run(new Form1(dbContext));
        }
    }
}