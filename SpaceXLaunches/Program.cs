using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Refit;
using SpaceXLaunches;
using SpaceXLaunches.Services;
using SpaceXLaunches.Services.SpaceXDataService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services
    .AddRefitClient<ISpaceXApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://api.spacex.land"));

builder.Services.AddTransient<ISpaceXDataService, SpaceXDataService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
