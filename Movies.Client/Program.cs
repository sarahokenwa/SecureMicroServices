using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Movies.Client.Data;
using Movies.Client.ApiService;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataEntities>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MoviesClientContext") ?? throw new InvalidOperationException("Connection string 'MoviesClientContext' not found.")));

builder.Services.AddScoped<IFilmApiService, FilmApiService>();

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

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

app.Run();
