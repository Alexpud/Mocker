using Mocker.Domain.Repositories;
using System;
using System.Threading.Tasks;

namespace Mocker.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T: class
    {
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public Task Commit()
        {
            throw new NotImplementedException();
        }
    }
}
