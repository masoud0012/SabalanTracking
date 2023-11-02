using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SabalanTracking.Models;
using SabalanTracking.ServiceContrcats;

namespace SabalanTracking.Controllers
{
    [Route("[Controller]")]
    public class FeedListController : Controller
    {
        private readonly IFormulla _fService;
        private readonly IFormullaDetails _dService;
        private readonly IProcess _pService;
        public FeedListController(IFormulla fService, IFormullaDetails dService
            , IProcess pService)
        {
            _fService = fService;
            _dService = dService;
            _pService = pService;
        }
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<string> GetAllSNByMaterialID(int id)
        {
            var formull = await _fService.GetByMaterialID(id);
            var details = await _dService.GetByFormullId(formull.Id);
            List<List<Proces>> list = new List<List<Proces>>();
            foreach (FormullaDetails item in details)
            {
                var model = await _pService.GetProcessByMateralId(item.MaterialId);
                list.Add(model);
            }
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented // optional, for pretty-printed JSON
            };

            string items = JsonConvert.SerializeObject(list, settings);
            return items;
        }
    }
}
