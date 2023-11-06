using Microsoft.AspNetCore.Mvc;
using SabalanTracking.Models;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Controllers
{
    [Route("[Controller]")]
    public class FormullaDetailsController : Controller
    {
        private readonly IFormullaDetails _service;
        private readonly IFormulla _formullService;
        public FormullaDetailsController(IFormullaDetails service, IFormulla formulla)
        {
            _service = service;
            _formullService = formulla;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<List<FormullaDetails>> GetSNsByFormullaID(int id)
        {
            var formull = await _formullService.GetByMaterialID(id);
            var list = await _service.GetByFormullId(formull.Id);
            return list;
        }

    }
}
