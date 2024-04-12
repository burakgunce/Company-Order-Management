using Application.Repositories;
using Domain.Primitives;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class CommandRepository<T> : ICommandRepository<T> where T : Entity
    {
        private readonly COManagementDbContext _context;

        public CommandRepository(COManagementDbContext context)
        {
            _context = context;
            Entity = _context.Set<T>();
        }

        public DbSet<T> Entity { get; set; }

        public async Task AddAsync(T entity)
        {
            await Entity.AddAsync(entity);
        }

        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveByIdAsync(string id)
        {
            T entity = await Entity.FindAsync(id);
            Remove(entity);
        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }
    }
}
