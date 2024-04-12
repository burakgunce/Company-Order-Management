using Application.Features.Commands.Product.CreateProduct;

namespace Application.Services
{
    public interface IProductService
    {
        Task AddAsync(CreateProductCommand request);
    }
}
