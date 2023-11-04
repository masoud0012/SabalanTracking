using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SabalanTracking.Models;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Controllers
{
    [Route("[Controller]")]
    public class MaterialController : Controller
    {
        private readonly IMaterial _service;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductCategory _catService;
        private readonly IUnit _unitService;
        public MaterialController(IMaterial service, IUnitOfWork unitOfWork,
            IProductCategory catService, IUnit unitService)
        {
            _service = service;
            _catService = catService;
            _unitService = unitService;
            _unitOfWork = unitOfWork;
        }

        [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            var list = await _service.GetAllAsync();
            foreach (var item in list)
            {
                var category = await _catService.GetById(item.CatId);
                var unit = await _unitService.GetById(item.UnitId.Value);
                item.ProductCat = category;
                item.Unit = unit;
            }
            return View(list);
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult Create()
        {
            var model = new Material();
            return View(model);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> Create(Material model)
        {
            await _service.Create(model);
            await _unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _service.GetById(id);

            return View(model);
        }

        [HttpPost]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(Material model)
        {
            await _service.delete(model.Id);
            await _unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await _service.GetById(id);

            return View(model);
        }

        [HttpPost]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Edit(Material model)
        {
            await _service.update(model);
            await _unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<string> GetById(int id)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented // optional, for pretty-printed JSON
            };
            var model = (await _service.GetById(id));
            var unit = await _unitService.GetById(model.UnitId.Value);
            model.Unit = unit;
            return JsonConvert.SerializeObject(model, settings);
        }
    }
}
