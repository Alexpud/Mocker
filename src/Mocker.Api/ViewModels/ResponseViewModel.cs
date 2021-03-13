using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mocker.Api.ViewModels
{
    public class ResponseViewModel
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Content { get; set; }
        public int RequestId { get; set; }
    }
}
