using Microsoft.EntityFrameworkCore;
using Sql_Servis.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProductDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("Default"));

});
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

app.Run();
