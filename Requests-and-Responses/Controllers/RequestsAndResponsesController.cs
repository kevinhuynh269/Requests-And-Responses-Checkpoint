using Microsoft.AspNetCore.Mvc;

namespace Requests_and_Responses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestsAndResponsesController : ControllerBase
    {
        // GET
        public RequestsAndResponsesController()
        {
            
        }
        [HttpGet("RequestHeaders")]
        public IActionResult Get()
        {
            return Ok(base.Request.Headers);
        }
        
        [HttpGet("ListOfQueryNamesAndValues")]
        public IActionResult ListOfQueryNamesAndValues(int val1, int val2)
        {
            return Ok(base.Request.Query);
        }
        
    }
}