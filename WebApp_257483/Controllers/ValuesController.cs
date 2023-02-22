using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json;
using WebApp_257483.Models;
using WebApp_257483.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp_257483.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IGetDatas _getDatas;

        public ValuesController(IGetDatas getDatas)
        {
            _getDatas = getDatas;  
        }

        [HttpGet("{id}/{radius}")]
        public IActionResult Get(string id, string radius)
        {
            return new JsonResult(_getDatas.GetDataAssets(id, radius).Result,
                                    new JsonSerializerOptions { PropertyNamingPolicy = null });
        }
    }
}
