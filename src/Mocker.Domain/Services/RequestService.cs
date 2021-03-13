using AutoMapper;
using Mocker.Domain.Dtos;
using Mocker.Domain.Entities;
using Mocker.Domain.Repositories;
using Mocker.Dtos;
using System.Threading.Tasks;

namespace Mocker.Domain.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IMapper _mapper;

        public RequestService(IRequestRepository requestRepository, IMapper mapper)
        {
            _requestRepository = requestRepository;
            _mapper = mapper;
        }

        public async Task<AddRequestDto> AddRequest(RequestDto dto)
        {
            var addRequestDto = new AddRequestDto();
            var request = _mapper.Map<Request>(dto);
            var notification = request.ValidationErrors();
            if (notification.HasErrors())
            {
                addRequestDto.Notification = notification;
                return addRequestDto;
            }

            _requestRepository.Add(request);
            await _requestRepository.Commit();
            addRequestDto.Id = request.Id;

            return _mapper.Map<AddRequestDto>(request);
        }
    }
}
