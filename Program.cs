using Microsoft.EntityFrameworkCore;
using PromotigoMVC.data;
using PromotigoMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PromotigoMVCDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PromotigoMVC")));
    builder.Services.AddScoped<IWinnersRepository, WinnersRepository>();
var app = builder.Build();



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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{numWinners?}");

app.Run();
