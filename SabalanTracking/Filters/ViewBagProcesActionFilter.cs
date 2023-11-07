using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Filters
{
    public class ViewBagProcesActionFilter:IAsyncActionFilter
    {
        private readonly IRepoProcess _repo;
        public ViewBagProcesActionFilter(IRepoProcess repo)
        {
            _repo = repo;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var list = await _repo.GetAllAsync();
            ((Controller)context.Controller).ViewBag.Proces = list.Select(t =>
            new SelectListItem() { Value = t.SN, Text = "||نام متریال:" + t.Material.Name + "||شماره سریال=" + t.SN + " ||  تعداد=" + t.Quantity });
            await next();
        }
    }
}
