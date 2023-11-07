using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Filters
{
    public class ViewBagMaterialsActionFilter : IAsyncActionFilter
    {
        private readonly IRepoMaterial _repo;
        public ViewBagMaterialsActionFilter(IRepoMaterial repo)
        {
            _repo = repo;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var list = await _repo.GetAllAsync();
            ((Controller)context.Controller).ViewBag.Materials = list.Select(t =>
             new SelectListItem() { Value = t.Id.ToString(), Text = t.Name });

            ((Controller)context.Controller).ViewBag.MaterialList = new SelectList(
               list.Select(t => new SelectListItem
               {
                   Value = t.Id.ToString(),
                   Text = t.Name
               }), "Value", "Text");

            await next();
        }
    }
}
