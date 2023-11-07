using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Filters
{
    public class ViewBagProcessNamesActionFilter : IAsyncActionFilter
    {
        private readonly IRepoProcessName _repo;
        public ViewBagProcessNamesActionFilter(IRepoProcessName repo)
        {
            _repo = repo;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var list = await _repo.GetAllAsync();
            ((Controller)context.Controller).ViewBag.ProcessNames = list.Select(t =>
             new SelectListItem() { Value = t.Id.ToString(), Text = t.Name });
            await next();
        }
    }
}
