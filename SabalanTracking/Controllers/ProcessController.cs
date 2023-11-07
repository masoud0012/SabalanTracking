using Microsoft.AspNetCore.Mvc;
using SabalanTracking.Models;
using SabalanTracking.Filters;
using SabalanTracking.ServiceContrcats;
using SabalanTracking.Helper;
using SabalanTracking.Models.IRepository;

namespace SabalanTracking.Controllers
{
    [Route("[Controller]")]
    public class ProcessController : Controller
    {
        private readonly IProcess _processService;
        private readonly IFormullaDetails _formullaDetails;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProcessDetails _detailsService;
        public ProcessController(IProcess processService, IFormullaDetails formullaDetails
            , IUnitOfWork unitOfWork,IProcessDetails DetailsService)
        {
            _processService = processService;
            _detailsService = DetailsService;
            _formullaDetails = formullaDetails;
            _unitOfWork = unitOfWork;
        }
        [Route("[action]")]
        public async Task<IActionResult> Index()
        {
            string message = TempData["message"] as string;

            if (message != null)
            {
                ViewBag.Message = message;
            }

            List<Proces> processes = (await _processService.GetAllAsync());
            return View(processes);
        }

        [Route("[action]")]
        [HttpGet]
        [TypeFilter(typeof(ViewBagDevicesActionFilter))]
        [TypeFilter(typeof(ViewBagFurmullaActionFilter))]
        [TypeFilter(typeof(ViewBagMaterialsActionFilter))]
        [TypeFilter(typeof(ViewBagPeopleActionFilter))]
        [TypeFilter(typeof(ViewBagProcesActionFilter))]
        [TypeFilter(typeof(ViewBagProcessNamesActionFilter))]
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
            await _unitOfWork.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await _processService.GetById(id);
            List<ProcessDetaile> used =await _detailsService.GetDetailsBySN(model.SN);
            if (used.Count ==0)
            {
                return View(model);
            }
            TempData["message"] = "این فرآیند در فرایندهای دیگر استفاده شده و قابل حدف شدن نیست";
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("[action]/{id}")]
        public async Task<IActionResult> Delete(Material model)
        {
            await _processService.delete(model.Id);
            await _unitOfWork.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<string> getProcessByMaterialID(int id)
        {
            var list = new List<List<Proces>>();
            var formullaDetails = await _formullaDetails.GetFormullaDetailsByMaterialId(id);
            foreach (var item in formullaDetails)
            {
                list.Add(await _processService.GetProcessByMateralId(item.MaterialId));
            }
            return await ConvertObjToJson.ConvertToJson(list);
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<string> getProcessByFormullaID(int id)
        {
            var formullaDetails = await _formullaDetails.GetByFormullId(id);
            List<Proces> list = new List<Proces>();
            foreach (var item in formullaDetails)
            {
                List<Proces> tempList = await _processService.GetProcessByMateralId(item.MaterialId);
                list.AddRange(tempList);
            }
            return await ConvertObjToJson.ConvertToJson(list);
        }
    }
}
