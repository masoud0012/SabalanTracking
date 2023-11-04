using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SabalanTracking.Models;
using SabalanTracking.Data;

namespace SabalanTracking.Filters
{
    public class ViewBagActionFilter : IAsyncActionFilter
    {
        private readonly TrackingDbContext _dbContext;
        private List<Person> _people;
        private List<Material> _materials;
        private List<Device> _devices;
        private List<ProcessName> _processNames;
        private List<Proces> _processes;
        private List<Formulla> _formulla;
        public ViewBagActionFilter(TrackingDbContext dbContext)
        {
            _dbContext = dbContext;
            _people = new List<Person>();
            _materials = new List<Material>();
            _devices = new List<Device>();
            _processNames = new List<ProcessName>();
            _processes = new List<Proces>();
            _formulla = new List<Formulla>();
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _people = await _dbContext.Persons.ToListAsync();
            _materials = await _dbContext.Materials.ToListAsync();
            _devices = await _dbContext.Devices.ToListAsync();
            _processNames = await _dbContext.ProcessNames.ToListAsync();
            _processes = await _dbContext.Processes.ToListAsync();
            _formulla = await _dbContext.Formulas.ToListAsync();


            ((Controller)context.Controller).ViewBag.Furmulla = _formulla.Select(t =>
             new SelectListItem() { Value = t.Id.ToString(), Text = t.Name });

            ((Controller)context.Controller).ViewBag.People = _people.Select(t =>
            new SelectListItem() { Value = t.Id.ToString(), Text = t.Name });

            ((Controller)context.Controller).ViewBag.Materials = _materials.Select(t =>
            new SelectListItem() { Value = t.Id.ToString(), Text = t.Name });

            ((Controller)context.Controller).ViewBag.Devices = _devices.Select(t =>
             new SelectListItem() { Value = t.Id.ToString(), Text = t.Name });

            ((Controller)context.Controller).ViewBag.ProcessNames = _processNames.Select(t =>
           new SelectListItem() { Value = t.Id.ToString(), Text = t.Name });

            ((Controller)context.Controller).ViewBag.Proces2 = _processes.Select(t =>
            new SelectListItem() { Value = t.SN, Text = "||نام متریال:" + t.Material.Name + "||شماره سریال=" + t.SN + " ||  تعداد=" + t.Quantity });
/*            ((Controller)context.Controller).ViewBag.Process = new SelectList(_processes.Select(t => new SelectListItem
            {
                Value = t.SN,
                Text = "||نام متریال:" + t.Material.Name + "||شماره سریال=" + t.SN + " ||  تعداد=" + t.Quantity
            }),
       "Value", "Text");*/
            ((Controller)context.Controller).ViewBag.MaterialList = new SelectList(
                _materials.Select(t => new SelectListItem
                {
                    Value = t.Id.ToString(),
                    Text = t.Name
                }), "Value", "Text");
            await next();
        }
    }
}
