using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.Product.CreateProduct
{
    public sealed record CreateProductCommand(
    string CompanyId,
    string ProductName,
    decimal Stock,
    decimal Price) : IRequest<CreateProductCommandResponse>;
}
