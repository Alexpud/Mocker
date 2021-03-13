using Mocker.Domain.Dtos;
using System.Threading.Tasks;

namespace Mocker.Domain.Services
{
    public interface IRequestService
    {
        Task<AddRequestDto> AddRequest(RequestDto dto);
    }
}
