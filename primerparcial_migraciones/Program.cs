using Microsoft.EntityFrameworkCore;
using primerparcial_migraciones.Datos;
using primerparcial_migraciones.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<GestionMedicaContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("GestionMedicaConnection_Orlando_2019-1288"))

); 
var app = builder.Build();
using (var scope= app.Services.CreateScope())
{
 var dataContext = scope.ServiceProvider.GetRequiredService<GestionMedicaContext>();
    dataContext.Database.Migrate();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
