using System.Collections.Generic;
using System.Linq;

namespace Mocker.Dtos
{
    public class Notification
    {
        public List<string> Errors { get; } = new List<string>();
        public bool HasErrors() => Errors.Any();
        public void AddError(string errorMessage) => Errors.Add(errorMessage);
    }
}
