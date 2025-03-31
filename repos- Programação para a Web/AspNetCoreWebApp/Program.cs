using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AspNetCoreWebApp.Data;
/*using Microsoft.AspNetCore.Mvc.Razor;*/

 var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages()
    .AddRazorRuntimeCompilation();
/*using Microsoft.AspNetCore.Mvc.Razor;*/

 builder.Services.AddDbContext<ApplicationDbContext>(options =>
/*using Microsoft.AspNetCore.Mvc.Razor;*/

     options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDbContext") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContext' not found.")));

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting(); 

app.UseAuthorization();

app.MapRazorPages();

app.Run(); 


/*var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation(); // Adiciona suporte � recompila��o em tempo de execu��o

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();
*/