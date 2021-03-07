using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Mocker.Domain.Dtos;
using Mocker.Domain.Services;
using System.Threading.Tasks;

namespace Mocker.Controllers
{
    //[ApiController]
    public class RequestController : ControllerBase
    {
        private readonly ILogger<RequestController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IRequestService _requestService;
        public RequestController(ILogger<RequestController> logger, IRequestService requestService, IConfiguration configuration)
        {
            _logger = logger;
            _configuration =configuration;
            _requestService = requestService;
        }

        [HttpPost("api/v1/request/")]
        public async Task<IActionResult> AddRequest(RequestDto requestDto)
        {
            await _requestService.AddRequest(requestDto);
            return Ok();
        }

        public IActionResult Test()
        {
            return Ok(_configuration.GetSection("Something"));
        }
    }
}
