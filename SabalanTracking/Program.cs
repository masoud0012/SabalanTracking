using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SabalanTracking;
using SabalanTracking.Data;
using SabalanTracking.Data.Repository;
using SabalanTracking.Models.IdentityEntities;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;
using SabalanTracking.Services;

var builder = WebApplication.CreateBuilder(args);

builder.ServiceExtension();
//configure identity
//configure for Identity
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(option =>
{
    option.Password.RequiredLength = 3;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequireUppercase = false;
    option.Password.RequireDigit = false;
})
    .AddDefaultTokenProviders()
    //configure for Users table
    .AddUserStore<UserStore<ApplicationUser,ApplicationRole,TrackingDbContext,Guid>>()
    //configure for role table
    .AddRoleStore<RoleStore<ApplicationRole,TrackingDbContext,Guid>>();


builder.Services.AddDbContext<TrackingDbContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Details}/{id?}");

app.Run();
