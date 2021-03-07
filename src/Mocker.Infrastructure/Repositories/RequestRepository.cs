using Mocker.Domain.Entities;
using Mocker.Domain.Repositories;

namespace Mocker.Infrastructure.Repositories
{
    public class RequestRepository : Repository<Request>, IRequestRepository
    {
    }
}
