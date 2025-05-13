using foy5_OgrenciYonetimSistemi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// MVC için 
builder.Services.AddControllersWithViews();

// DbContext 
builder.Services.AddDbContext<Foy5Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Foy5Connection")));

var app = builder.Build();

// Pipeline ayarları
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ❗ MVC Controller'lar için route tanımı
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
