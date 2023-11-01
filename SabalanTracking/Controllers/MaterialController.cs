using Microsoft.AspNetCore.Mvc;
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
        public MaterialController(IMaterial service, IUnitOfWork unitOfWork)
        {
            _service = service;
            _unitOfWork = unitOfWork;
        }

        [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            var list = await _service.GetAllAsync();
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
    }
}
