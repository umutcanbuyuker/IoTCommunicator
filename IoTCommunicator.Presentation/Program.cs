using IoTCommunicator.Business.Interfaces;
using IoTCommunicator.Business.Services;
using IoTCommunicator.Data.DataContext.Repositories.Abstract;
using IoTCommunicator.Data.DataContext.Repositories.Concrete;
using IoTCommunicator.Presentation.Forms;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;

namespace IoTCommunicator.Presentation
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<RestClient>(sp => new RestClient("http://192.168.127.254"))
                .AddHttpClient()
                .AddSingleton<IApiRepository, ApiRepository>()
                .AddSingleton<IApiService, ApiService>()
                .AddSingleton<MainForm>()
                .BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }
    }
}