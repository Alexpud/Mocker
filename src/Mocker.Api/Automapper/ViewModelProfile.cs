using AutoMapper;
using Mocker.Api.ViewModels;
using Mocker.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mocker.Api.Automapper
{
    public class ViewModelProfile : Profile
    {
        public ViewModelProfile()
        {
            CreateMap<AddRequestViewModel, RequestDto>().ReverseMap();
            CreateMap<ResponseViewModel, ResponseDto>().ReverseMap();
            CreateMap<QueryParamViewModel, QueryParamDto>().ReverseMap();
        }
    }
}
