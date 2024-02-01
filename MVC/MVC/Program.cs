using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC.Data;
using MVC.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCContext") ?? throw new InvalidOperationException("Connection string 'MVCContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

/*MVC invokes controller classes, and the action methods within 
 * them, depending on the incoming URL. The default 
 * URL routing logic used by MVC, 
 * uses a format like this to determine what code to invoke:*****************************/
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
