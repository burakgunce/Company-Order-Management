using Domain.Primitives;
using System.Linq.Expressions;

namespace Application.Repositories
{
    public interface IQueryRepository<T> : IRepository<T> where T : Entity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);
        Task<T> GetFirstByExpiression(Expression<Func<T, bool>> expression);
        Task<T> GetFirstById(string id);
    }
}
