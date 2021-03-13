using Mocker.Domain.Dtos;
using Mocker.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mocker.Api.ViewModels
{
    public class AddRequestViewModel
    {
        public string Path { get; set; }
        public ResponseViewModel R { get; set; }
        public List<QueryParamViewModel> QueryParams { get; set; } = new List<QueryParamViewModel>();
        public List<ResponseViewModel> Responses { get; set; } = new List<ResponseViewModel>();
        public Notification Notification { get; set; }
    }
}
