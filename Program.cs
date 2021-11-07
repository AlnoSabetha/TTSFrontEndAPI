using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TTSfront_end.Services;

namespace TTSfront_end
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            var uri = new Uri("https://blazorbackend.azurewebsites.net");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = uri });
            builder.Services.AddScoped<IDepartmentsSeervice,DepartmentServices>();
            builder.Services.AddScoped<IEmployeesService,EmployeesService>();

            await builder.Build().RunAsync();
        }
    }
}
