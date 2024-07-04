using HR.ScheduleManagement.Blazor;
using HR.ScheduleManagement.Blazor.Contracts;
using HR.ScheduleManagement.Blazor.Services;
using HR.ScheduleManagement.Blazor.Services.Base;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri("http://localhost:5293"));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IEmployeeTypeService, EmployeeTypeService>();
builder.Services.AddScoped<ITaskTypeService, TaskTypeService>();

await builder.Build().RunAsync();
