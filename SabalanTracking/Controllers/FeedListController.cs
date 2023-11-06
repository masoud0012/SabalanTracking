using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SabalanTracking.Helper;
using SabalanTracking.Models;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Controllers
{
    [Route("[Controller]")]
    public class FeedListController : Controller
    {
        private readonly IFormulla _fService;
        private readonly IFormullaDetails _fdService;
        private readonly IProcess _pService;
        public FeedListController(IFormulla fService, IFormullaDetails dService
            , IProcess pService)
        {
            _fService = fService;
            _fdService = dService;
            _pService = pService;
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<string> GetAllSNByMaterialID(int id)
        {

            List<List<Proces>> list = new List<List<Proces>>();
            var formull = await _fService.GetByMaterialID(id);
            if (formull is null)
            {
                return JsonConvert.SerializeObject(list);
            }
            var details = await _fdService.GetByFormullId(formull.Id);
            foreach (FormullaDetails item in details)
            {
                var model = await _pService.GetProcessByMateralId(item.MaterialId);
                list.Add(model);
            }
            return await ConvertObjToJson.ConvertToJson(list);
        }

        [HttpGet]
        [Route("[action]/{SN}")]
        public async Task<string> GetFormullaBySN(string SN)
        {
            Proces proces = await _pService.GetProcessBySN(SN);
            Formulla formulla = await _fService.GetByMaterialID(proces.MaterialId);
            return await ConvertObjToJson.ConvertToJson(formulla);
        }

        [HttpGet]
        [Route("[action]/{formullId}/{SN}")]
        public async Task<double> GetQuantity(int formullId,string SN)
        {
            var process=await _pService.GetProcessBySN(SN);
            double quantity =await _fdService.GetQuantityByFormullIdAndMaterialId(formullId,process.MaterialId);
            return quantity;
        }
    }
}
