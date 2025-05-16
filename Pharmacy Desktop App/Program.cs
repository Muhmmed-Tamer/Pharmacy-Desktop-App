using Business_Layer.UnitOFWork;
using Microsoft.Extensions.DependencyInjection;
using Pharmacy_Desktop_App.Admin;

namespace Pharmacy_Desktop_App
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceProvider = ServiceProviderConfig.ConfigureServices();
            var mainForm = ServiceProvider.GetRequiredService<Login>();
            Application.Run(mainForm);
        }
    }
}