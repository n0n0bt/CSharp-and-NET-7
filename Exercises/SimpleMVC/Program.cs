using Microsoft.EntityFrameworkCore;
using SimpleMVC.Data;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<SimpleMvcDBContext>(option=>option.UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Start}/{action=Index}");

//app.MapRazorPages();

app.Run();
