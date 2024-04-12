using Application.Repositories.CompanyRepositories;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories.CompanyRepositories
{
    public sealed class CompanyQueryRepository : QueryRepository<Company>, ICompanyQueryRepository
    {
        public CompanyQueryRepository(COManagementDbContext context) : base(context)
        {
        }
    }
}
