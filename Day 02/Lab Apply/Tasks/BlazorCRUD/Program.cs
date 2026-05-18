using BlazorCRUD.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SharedEntities;

namespace BlazorCRUD
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            var apiUrl = builder.Configuration["ApiSettings:TargetApiUrl"];
            builder.Services.AddHttpClient<IBaseRepository<Trainee>, BaseRepository<Trainee>>(
                 httpClient => httpClient.BaseAddress = new Uri(apiUrl));
            builder.Services.AddHttpClient<IBaseRepository<Track>, BaseRepository<Track>>(
                 httpClient => httpClient.BaseAddress = new Uri(apiUrl));

            await builder.Build().RunAsync();
        }
    }
}
