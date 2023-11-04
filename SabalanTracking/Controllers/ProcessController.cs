using Microsoft.AspNetCore.Mvc;
using SabalanTracking.Models;
using SabalanTracking.Filters;
using SabalanTracking.ServiceContrcats;
using Newtonsoft.Json;
using SabalanTracking.Helper;

namespace SabalanTracking.Controllers
{
    [Route("[Controller]")]
    public class ProcessController : Controller
    {
        private readonly IProcess _processService;
        private readonly IFormullaDetails _formullaDetails;
        public ProcessController(IProcess processService, IFormullaDetails formullaDetails)
        {
            _processService = processService;
            _formullaDetails = formullaDetails;
        }
        [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            List<Proces> processes = (await _processService.GetAllAsync());
            return View(processes);
        }

        [Route("[action]")]
        [HttpGet]
        [TypeFilter(typeof(ViewBagActionFilter))]
        public async Task<IActionResult> Create()
        {

            Proces process = new Proces();
            process.ProcessDetails.Add(new ProcessDetaile() { Id = 1 });
            return View(process);
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<IActionResult> Create(Proces process)
        {
            foreach (var item in process.ProcessDetails)
            {
                if (item.Product_SN == null & item.QntyPerPc == 0)
                {
                    process.ProcessDetails.Remove(process.ProcessDetails.Last());
                }
            }
            if (process.ProcessNameId != 1)
            {
                if (process.ProcessDetails.Count == 0)
                {
                    return RedirectToAction("Create");
                }
            }
            process.SN = SnGenerator.GenerateSN(process);
            await _processService.Create(process);
            return RedirectToAction("Index");
        }

        [Route("[action]")]
        [Route("[action]/{Id}")]
        [HttpGet]
        public async Task<string> getProcessByMaterialID(int id)
        {
            var list = new List<List<Proces>>();
            var formullaDetails = await _formullaDetails.GetFormullaDetailsByMaterialId(id);
            foreach (var item in formullaDetails)
            {
                list.Add(await _processService.GetProcessByMateralId(item.MaterialId));
            }
            return JsonConvert.SerializeObject(list);
        }

    }
}
