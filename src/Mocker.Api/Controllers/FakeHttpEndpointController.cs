using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mocker.Api.Controllers
{
    public class FakeHttpEndpointController : ControllerBase
    {
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
