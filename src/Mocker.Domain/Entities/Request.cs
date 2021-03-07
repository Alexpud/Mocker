using Mocker.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mocker.Domain.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public List<QueryParam> QueryParams { get; set; } = new List<QueryParam>();
        public List<Response> Responses { get; set; } = new List<Response>();
        
        public Notification ValidationErrors()
        {
            var notification = new Notification();
            if (string.IsNullOrWhiteSpace(Path))
                notification.AddError("Path can't be an empty string");

            if (!HasValidPath())
                notification.AddError("Path doesnt pass for a valid URI");

            var pathContainsProhibitedCharacter = Path is null ? true : Path.Contains('.');
            if (pathContainsProhibitedCharacter)
                notification.AddError("Path cannot prohibited character '.'");

            if (!Responses.Any())
                notification.AddError("A request cannot be registered without responses");

            return notification;
        }

        private bool HasValidPath()
        {
            try
            {
                var uri = new Uri("http://teste.com" + Path);
                return true;
            }
            catch(UriFormatException exception)
            {
                return false;
            }
        }
    }
}