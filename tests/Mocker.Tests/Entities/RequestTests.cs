using Mocker.Domain.Entities;
using System.Linq;
using Xunit;

namespace Mocker.Tests.Entities
{
    public class RequestTests
    {

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddRequest_Should_ReturnError_When_RequestPath_IsEmptyOrNull(string path)
        {
            // arrange
            var request = new Request()
            {
                Path = path
            };

            // act
            var notification = request.ValidationErrors();

            // assert
            Assert.True(notification.HasErrors());
        }


        [Theory]
        [InlineData("@")]
        public void ValidationErrors_Should_ReturnError_When_RequestPath_IsInvalid(string path)
        {
            // arrange
            var request = new Request()
            {
                Path = path
            };

            // act
            var notification = request.ValidationErrors();

            // assert
            Assert.True(notification.HasErrors());
        }

        [Fact]
        public void ValidationErrors_Should_ReturnError_When_RequestPath_ContainsFileExtensions()
        {
            // arrange
            var request = new Request()
            {
                Path = "/path1/path2/file.extension"
            };

            // act
            var notification = request.ValidationErrors();

            // assert
            Assert.True(notification.HasErrors());
            Assert.Equal("Path cannot prohibited character '.'", notification.Errors.First());
        }
    }
}
