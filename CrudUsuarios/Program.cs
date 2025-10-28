// ASP.NET Core version for the code: 8.0 (2 files)
// Entity Framework Core version for the code: 8.0 (2 files)    
using Microsoft.EntityFrameworkCore;

using CrudUsuarios.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the database context to use SQL Server (2 filas) ✅ Nombre de conexión debe coincidir con el de appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL") ?? throw new InvalidOperationException("Connection string 'ConexionSQL' not found.")));

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
