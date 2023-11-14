using Microsoft.AspNetCore.Mvc;
using SabalanTracking.Models;
using SabalanTracking.Filters;
using SabalanTracking.ServiceContrcats;
using SabalanTracking.Models.IRepository;
using SabalanTracking.Helper;

namespace SabalanTracking.Controllers
{
   // [Route("[Controller]")]
    [TypeFilter(typeof(ViewBagFurmullaActionFilter))]
    public class FormullaController : Controller
    {
        private readonly IFormulla _formullaService;
        private readonly IFormullaDetails _formullaDetailsService;
        private readonly IUnitOfWork _unitOfWork;
        public FormullaController(IFormulla formullaService,
            IFormullaDetails formullaDetailsService,
            IUnitOfWork unitOfWork)
        {
            _formullaService = formullaService;
            _formullaDetailsService = formullaDetailsService;
            _unitOfWork = unitOfWork;
        }
       // [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            List<Formulla> formulas = await _formullaService.GetAllAsync();
            return View(formulas);
        }

        [HttpGet]
        //[Route("[action]")]
        [TypeFilter(typeof(ViewBagMaterialsActionFilter))]
        public IActionResult Create()
        {
            Formulla formula = new Formulla();
            formula.formullaDetails.Add(new FormullaDetails() { Id = 1 });
            return View(formula);
        }

        [HttpPost]
       // [Route("[action]")]
        public async Task<IActionResult> Create(Formulla formulla)
        {
            if (formulla is null)
            {
                return null;
            }
            await _formullaService.Create(formulla);
           await _unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
       // [Route("[action]/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var detail = await _formullaDetailsService.GetByFormullId(id);
            ViewBag.Prodct = await _formullaService.GetById(id);
            return View(detail);
        }

        [HttpGet]
        //[Route("[action]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _formullaService.GetById(id);
            return View(model);
        }

        [HttpPost]
       // [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(Formulla formulla)
        {
            await _formullaService.delete(formulla.Id);
            await _unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
       // [Route("[action]/{id}")]
        public async Task<string> GetByMaterialId(int id)
        {
            var list = await _formullaService.GetByMaterialID(id);
            return await ConvertObjToJson.ConvertToJson(list);
        }
    }
}
