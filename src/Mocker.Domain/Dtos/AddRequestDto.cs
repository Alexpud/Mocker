using Mocker.Dtos;
using System.Linq;

namespace Mocker.Domain.Dtos
{
    public class AddRequestDto
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Notification Notification { get; set; }
        public bool IsValid() => !Notification.Errors.Any();
    }
}
