using System.Net;

namespace Mocker.Domain.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Content { get; set; }
        public int RequestId { get; set; }
    }
}