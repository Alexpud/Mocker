using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Mocker.Api.ViewModels;
using Mocker.Domain.Dtos;
using Mocker.Domain.Services;
using System.Threading.Tasks;

namespace Mocker.Controllers
{
    [ApiController]
    public class RequestController : Controller
    {
        private readonly ILogger<RequestController> _logger;
        private readonly IRequestService _requestService;
        private readonly IMapper _mapper;

        public RequestController(ILogger<RequestController> logger, IRequestService requestService, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _requestService = requestService;
        }


        /// <summary>
        ///  Creates a request mock on the database
        /// </summary>
        /// <param name="viewModel">Information of the endpoint</param>
        /// <returns></returns>
        [HttpPost("api/v1/request/")]
        public async Task<IActionResult> AddRequest(AddRequestViewModel viewModel)
        {
            var addRequestDto = _mapper.Map<RequestDto>(viewModel);
            var addRequest = await _requestService.AddRequest(addRequestDto);
            if (!addRequest.IsValid())
                return BadRequest(addRequest.Notification);

            var addRequestViewModel = _mapper.Map<AddRequestDto, AddRequestViewModel>(addRequest); 
            return Ok(addRequestViewModel);
        }
    }
}
