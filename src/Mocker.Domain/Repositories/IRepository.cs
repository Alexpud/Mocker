using System.Threading.Tasks;

namespace Mocker.Domain.Repositories
{
    public interface IRepository<T> where T:class
    {
        void Add(T item);
        Task Commit();
    }
}
