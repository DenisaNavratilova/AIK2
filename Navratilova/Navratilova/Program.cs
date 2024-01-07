using Microsoft.EntityFrameworkCore;
using Navratilova;
using Navratilova.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<CreditsContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-QLS0GCM\\SQLEXPRESS;Database=Credits;Trusted_Connection=True;TrustServerCertificate=True;");
});
builder.Services.AddScoped<LogicCredits>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();