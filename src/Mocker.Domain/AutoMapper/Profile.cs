using AutoMapper;
using Mocker.Domain.Dtos;
using Mocker.Domain.Entities;

namespace Mocker.Domain.AutoMapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Request, RequestDto>().ReverseMap();
            CreateMap<QueryParam, QueryParamDto>().ReverseMap();
            CreateMap<Response, ResponseDto>().ReverseMap();
            CreateMap<Request, AddRequestDto>();
        }
    }
}
