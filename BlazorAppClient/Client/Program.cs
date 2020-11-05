using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Blazored.LocalStorage;
using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;

namespace BlazorAppClient.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddSweetAlert2();
            builder.Services.AddLogging();
            builder.Services.AddBlazoredToast();
            builder.Services.AddBlazoredLocalStorage(config =>
            config.JsonSerializerOptions.WriteIndented = true);
            builder.Services.AddHttpClient("BlazorAppClient.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                ;//.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BlazorAppClient.ServerAPI"));
            builder.Services.AddApiAuthorization();
            await builder.Build().RunAsync();
        }
    }
}
