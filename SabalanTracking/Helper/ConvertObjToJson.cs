using Newtonsoft.Json;
using System.Collections.Generic;

namespace SabalanTracking.Helper
{
    public static class ConvertObjToJson
    {
        public static async Task<string> ConvertToJson(object obj)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented // optional, for pretty-printed JSON
            };
            return JsonConvert.SerializeObject(obj, settings);
        }
    }
}
