using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyTestBlazor;
using MyTestBlazor.Repo;
using MyTestBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddSingleton(sp => new SingletontServices());
builder.Services.AddTransient(sp => new TransientServices());
builder.Services.AddTransient<IRepository, MockGamesRepository>();

await builder.Build().RunAsync();