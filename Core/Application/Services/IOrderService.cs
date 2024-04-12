using Application.Features.Commands.Order.CreateOrder;

namespace Application.Services
{
    public interface IOrderService
    {
        Task CreateOrder(CreateOrderCommand request);
    }
}
