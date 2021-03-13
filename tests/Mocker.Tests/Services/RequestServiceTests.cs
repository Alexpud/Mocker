using AutoMapper;
using Mocker.Domain.Dtos;
using Mocker.Domain.Entities;
using Mocker.Domain.Repositories;
using Mocker.Domain.Services;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Mocker.Tests.Services
{
    public class RequestServiceTests
    {
        private RequestService _requestService;
        private Mock<IRequestRepository> _requestRepositoryMock;
        private Mock<IMapper> _mapperMock;
        public RequestServiceTests()
        {
            _requestRepositoryMock = new Mock<IRequestRepository>();
            _mapperMock = new Mock<IMapper>();
        }

        [Fact]
        public async Task AddRequest_Should_ReturnError_When_RequestHasValidationErrors()
        {
            // arrange
            var invalidPath = ".invalid";
            var request = new RequestDto()
            {
                Path = invalidPath
            };

            _mapperMock.Setup(p => p.Map<Request>(It.IsAny<RequestDto>()))
                .Returns(new Request()
                {
                    Path = invalidPath
                });

            _requestService = new RequestService(_requestRepositoryMock.Object, _mapperMock.Object);
            
            // act
            var requestDto = await _requestService.AddRequest(request);

            // assert
            Assert.True(requestDto.Notification.HasErrors());
        }
    }
}