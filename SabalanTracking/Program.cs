using Microsoft.EntityFrameworkCore;
using SabalanTracking.Data;
using SabalanTracking.Data.Repository;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;
using SabalanTracking.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProcess, ProcessService>();
builder.Services.AddScoped<IProcessDetails, ProcessDetailsService>();
builder.Services.AddScoped<IFormullaDetails, FormullaDetailsService>();
builder.Services.AddScoped<IFormulla, FormullaService>();
builder.Services.AddScoped<IMaterial, MaterialService>();
builder.Services.AddScoped<IPeople, PersonService>();
builder.Services.AddScoped<IProductCategory, ProductCategoryService>();
builder.Services.AddScoped<IUnit, UnitService>();
builder.Services.AddScoped<IDevice, DeviceService>();
builder.Services.AddScoped<IProcessName, ProcessNameService>();


//Person
builder.Services.AddScoped<IRepoPeople, RepoPeople>();

//Material
builder.Services.AddScoped<IRepoMaterial, RepoMaterial>();

//ProductCat
builder.Services.AddScoped<IRepoProductCat, RepoProductCat>();

//Unit
builder.Services.AddScoped<IRepoUnit, RepoUnit>();

//Process
builder.Services.AddScoped<IRepoProcess, RepoProcess>();

//ProcessDetail
builder.Services.AddScoped<IRepoProcesDetails, RepoProcessDetails>();
//ProcessNameRepo
builder.Services.AddScoped<IRepoProcessName, RepoProcessName>();

//Formulla
builder.Services.AddScoped<IRepoFormulla, RepoFormulla>();

//FromullaDetails
builder.Services.AddScoped<IRepoFormullaDetails, RepoFormullaDetails>();

//Device
builder.Services.AddScoped<IRepoDevice, RepoDevice>();
//unitofwork
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


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
