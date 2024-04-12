using Application.Repositories.CompanyRepositories;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.CompanyRepositories
{
    public sealed class CompanyCommandRepository : CommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(COManagementDbContext context) : base(context)
        {
        }
    }
}
