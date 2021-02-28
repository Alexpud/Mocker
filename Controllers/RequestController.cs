using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
