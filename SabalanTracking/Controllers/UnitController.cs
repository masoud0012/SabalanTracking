using Microsoft.AspNetCore.Mvc;
using SabalanTracking.Models.IRepository;
using SabalanTracking.ServiceContrcats;
using SabalanTracking.Models;

namespace SabalanTracking.Controllers
{
    [Route("[Controller]")]
    public class UnitController : Controller
    {
        private readonly IUnit _service;
        private readonly IUnitOfWork _unitOfWork;
        public UnitController(IUnit service, IUnitOfWork unitOfWork)
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
            var model = new Unit();
            return View(model);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> Create(Unit model)
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
        public async Task<IActionResult> Delete(Unit model)
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
        public async Task<IActionResult> Edit(Unit model)
        {
            await _service.update(model);
            await _unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
