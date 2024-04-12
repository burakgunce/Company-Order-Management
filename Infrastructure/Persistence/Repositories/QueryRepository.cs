using Application.Repositories;
using Domain.Primitives;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class QueryRepository<T> : IQueryRepository<T> where T : Entity
    {
        private readonly COManagementDbContext _context;

        private readonly Func<COManagementDbContext, string, Task<T>> GetByIdCompiled =
            EF.CompileAsyncQuery((COManagementDbContext context, string id)
                =>
            context.Set<T>().FirstOrDefault(p => p.Id == id));

        public QueryRepository(COManagementDbContext context)
        {
            _context = context;
            Entity = _context.Set<T>();
        }

        public DbSet<T> Entity { get; set; }

        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
        }

        public async Task<T> GetFirstByExpiression(Expression<Func<T, bool>> expression)
        {
            return await Entity.FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetFirstById(string id)
        {
            return await GetByIdCompiled(_context, id);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return Entity.Where(expression);
        }
    }
}
