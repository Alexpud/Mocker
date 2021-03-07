using Mocker.Dtos;
using System.Collections.Generic;

namespace Mocker.Domain.Dtos
{
    public class RequestDto
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public List<QueryParamDto> QueryParams { get; set; } = new List<QueryParamDto>();
        public List<ResponseDto> Responses { get; set; } = new List<ResponseDto>();
        public Notification Notification { get; set; }
    }
}
