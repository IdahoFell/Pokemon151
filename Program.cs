using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pokemon151.Data;
using Pokemon151.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Pokemon151Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pokemon151Context") ?? throw new InvalidOperationException("Connection string 'Pokemon151Context' not found.")));


builder.Services.AddControllersWithViews();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
