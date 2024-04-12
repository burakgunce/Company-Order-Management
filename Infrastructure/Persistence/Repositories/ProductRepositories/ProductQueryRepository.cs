using Application.Repositories.ProductRepositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories.ProductRepositories
{
    public sealed class ProductQueryRepository : QueryRepository<Product>, IProductQueryRepository
    {
        public ProductQueryRepository(COManagementDbContext context) : base(context)
        {
        }
    }
}
