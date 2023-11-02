using Microsoft.AspNetCore.Mvc;
using SabalanTracking.Models;
using SabalanTracking.Filters;
using SabalanTracking.ServiceContrcats;
using NuGet.Protocol;
using Newtonsoft.Json;

namespace SabalanTracking.Controllers
{
    [Route("[Controller]")]
    [TypeFilter(typeof(ViewBagActionFilter))]
    public class FormullaController : Controller
    {
        private readonly IFormulla _formullaService;
        private readonly IFormullaDetails _formullaDetailsService;
        public FormullaController(IFormulla formullaService, IFormullaDetails formullaDetailsService)
        {
            _formullaService = formullaService;
            _formullaDetailsService = formullaDetailsService;
        }
        [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            List<Formulla> formulas = await _formullaService.GetAllAsync();
            return View(formulas);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Create()
        {
            Formulla formula = new Formulla();
            formula.formullaDetails.Add(new FormullaDetails() { Id = 1 });
            return View(formula);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Create(Formulla formulla)
        {
            if (formulla is null)
            {
                return null;
            }
            await _formullaService.Create(formulla);
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Details(int id)
        {
          var detail=  await _formullaDetailsService.GetByFormullId(id);
            return View(detail);
        }
    }
}
