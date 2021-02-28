using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Mocker.Controllers
{
    //[ApiController]
    public class RequestController : ControllerBase
    {
        private readonly ILogger<RequestController> _logger;
        public RequestController(ILogger<RequestController> logger)
        {
            _logger = logger;
        }

        public IActionResult Test()
        {
            return Ok();
        }
    }
}
