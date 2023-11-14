using SabalanTracking.Data.Repository;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;
using SabalanTracking.Services;

namespace SabalanTracking
{
    public static class Startup
    {
        public static void ServiceExtension(this WebApplicationBuilder builder)
        {

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


            //Repos
            builder.Services.AddScoped<IRepoPeople, RepoPeople>();
            builder.Services.AddScoped<IRepoMaterial, RepoMaterial>();
            builder.Services.AddScoped<IRepoProductCat, RepoProductCat>();
            builder.Services.AddScoped<IRepoUnit, RepoUnit>();
            builder.Services.AddScoped<IRepoProcess, RepoProcess>();
            builder.Services.AddScoped<IRepoProcesDetails, RepoProcessDetails>();
            builder.Services.AddScoped<IRepoProcessName, RepoProcessName>();
            builder.Services.AddScoped<IRepoFormulla, RepoFormulla>();
            builder.Services.AddScoped<IRepoFormullaDetails, RepoFormullaDetails>();
            builder.Services.AddScoped<IRepoDevice, RepoDevice>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

    }

}
