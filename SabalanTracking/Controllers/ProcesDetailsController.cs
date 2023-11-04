using Microsoft.AspNetCore.Mvc;
using SabalanTracking.DTO;
using SabalanTracking.Models;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Controllers
{
    [Route("[Controller]")]
    public class ProcesDetailsController : Controller
    {
        private readonly IProcessDetails _processDetails;
        private readonly IProcess _process;
        private readonly IUnit _unitService;
        public ProcesDetailsController(IProcessDetails processDetails,
            IProcess process,IUnit unitService)
        {
            _processDetails = processDetails;
            _process = process;
            _unitService = unitService;
        }
/*        [Route("[action]")]
        public async Task<IActionResult> PurchaseDetails(Proces proces)
        {
            return View(proces);
        }*/
        [Route("[action]/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var process = await _process.GetById(id);
            
            var list = await _processDetails.GetDetailsByProcessId(id);
            foreach (var item in list)
            {
                var unit = await _unitService.GetById(item.Process.MaterialId);
                item.Process.Material.Unit = unit;
            }
            List<ProcessDetailsResponse> newList = new List<ProcessDetailsResponse>();
            foreach (var item in list)
            {
              Proces proces=await _process.GetProcessBySN(item.Product_SN);
              newList.Add(proces.ToDetailsResponse(item,process.Quantity));
            }
            ViewBag.MainProcess = process;
            if (process.ProcessNameId==1 || list.Count==0)
            {
                return View("PurchaseDetails", process);

            }
            return View(newList);
        }
    }
}
