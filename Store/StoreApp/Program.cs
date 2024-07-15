using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RepositoryContext>(options => 
    {
        options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
        b => b.MigrationsAssembly("StoreApp"));
    });
var app = builder.Build();

app.UseStaticFiles(); // For the wwwroot folder
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}");

app.Run();
