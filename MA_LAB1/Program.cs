using MA_LAB1.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<TruckRouteDBContext>(opt =>
			opt.UseSqlServer(builder.Configuration["ConnectionStrings:TruckRouteConn"]));
builder.Services.AddScoped<IAccountRepository, RepositoryAccount>();
builder.Services.AddScoped<IRouteRepository, RepositoryRoute>();
builder.Services.AddScoped<ITruckRepository, RepositoryTruck>();
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
	pattern: "{controller=Home}/{action=Index}/{id?}");
Data.LoadData(app);
app.Run();
