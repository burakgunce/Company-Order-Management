using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.Company.GetAllCompany
{
    public sealed record GetAllCompanyQuery : IRequest<GetAllCompanyQueryResponse>;
}
