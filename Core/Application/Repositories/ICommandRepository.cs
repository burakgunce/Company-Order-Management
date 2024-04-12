using Domain.Primitives;

namespace Application.Repositories
{
    public interface ICommandRepository<T> : IRepository<T> where T : Entity
    {
        Task AddAsync(T entity);
        void Update(T entity);
        Task RemoveByIdAsync(string id);
        void Remove(T entity);
    }
}
