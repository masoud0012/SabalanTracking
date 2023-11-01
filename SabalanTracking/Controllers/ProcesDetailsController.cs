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
        public ProcesDetailsController(IProcessDetails processDetails,
            IProcess process)
        {
            _processDetails = processDetails;
            _process = process;
        }

        [Route("[action]/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var process = await _process.GetById(id);
            
            var list = await _processDetails.GetDetailsByProcessId(id);
            List<ProcessDetailsResponse> newList = new List<ProcessDetailsResponse>();
            foreach (var item in list)
            {
              Proces proces=await _process.GetProcessBySN(item.Product_SN);
              newList.Add(proces.ToDetailsResponse(item,process.Quantity));
            }
            ViewBag.MainProcess = process;
            
            return View(newList);
        }
    }
}
