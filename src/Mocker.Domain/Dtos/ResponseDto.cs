using System.Net;

namespace Mocker.Domain.Dtos
{
    public class ResponseDto
    {
        public int Id { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string Content { get; set; }
        public int RequestId { get; set; }
    }
}
