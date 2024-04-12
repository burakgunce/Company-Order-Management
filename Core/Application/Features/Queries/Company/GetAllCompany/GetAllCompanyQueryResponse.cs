using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.Company.GetAllCompany
{
    public sealed record GetAllCompanyQueryResponse(IQueryable<Domain.Entities.Company> Companies);
}
