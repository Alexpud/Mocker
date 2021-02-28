namespace Mocker.Entities
{
    public class Response
    {
        public int HttpStatusCode { get; set; }
        public string Content { get; set; }
        public int RequestId { get; set; }
    }
}