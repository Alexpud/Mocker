using System.Collections.Generic;

namespace Mocker.Entities
{
    public class Request
    {
        public string Path { get; set; }
        public List<QueryParam> QueryParams { get; set; }
        public List<Response> Responses { get; set; }
    }
}