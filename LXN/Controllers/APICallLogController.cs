using LXN.BLL;
using LXN.ML;
using Microsoft.AspNetCore.Mvc;

namespace LXN.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class APICallLogController : ControllerBase
    {
        [HttpPost("LoadInfo")]
        public async Task<IEnumerable<APICallLog>> LoadInfo(string APICallLogID)
        {
            return await BLL_APICallLog.LoadInfo(APICallLogID);
        }
    }
}
