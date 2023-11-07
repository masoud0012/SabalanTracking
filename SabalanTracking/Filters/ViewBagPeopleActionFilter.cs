using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Filters
{
    public class ViewBagPeopleActionFilter : IAsyncActionFilter
    {
        private readonly IRepoPeople _repo;
        public ViewBagPeopleActionFilter(IRepoPeople repo)
        {
            _repo = repo;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var list = await _repo.GetAllAsync();
            ((Controller)context.Controller).ViewBag.People = list.Select(t =>
             new SelectListItem() { Value = t.Id.ToString(), Text = t.Name });
            await next();
        }
    }
}
