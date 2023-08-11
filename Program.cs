using Microsoft.EntityFrameworkCore;
using MVC_WebApplication.Data;
using MVC_WebApplication.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVC_WebApplicationContext>
(
    options => options.UseMySql(builder.Configuration.GetConnectionString("MVC_WebApplicationContext"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MVC_WebApplicationContext")),
    builder => builder.MigrationsAssembly("MVC_WebApplication"))
);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.Services.CreateScope().ServiceProvider.GetRequiredService<SeedingService>().Seed();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute
(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();