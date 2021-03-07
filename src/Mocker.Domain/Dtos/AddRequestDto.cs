using Mocker.Dtos;

namespace Mocker.Domain.Dtos
{
    public class AddRequestDto
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Notification Notification { get; set; }
    }
}
