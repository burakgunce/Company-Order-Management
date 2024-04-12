using Application.Repositories.OrderRepositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories.OrderRepositories
{
    public sealed class OrderQueryRepository : QueryRepository<Order>, IOrderQueryRepository
    {
        public OrderQueryRepository(COManagementDbContext context) : base(context)
        {
        }
    }
}
