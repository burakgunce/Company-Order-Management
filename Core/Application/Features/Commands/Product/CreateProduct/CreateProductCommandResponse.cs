using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands.Product.CreateProduct
{
    public sealed record CreateProductCommandResponse(
    string Message = "Ürün başarıyla eklendi!");
}
