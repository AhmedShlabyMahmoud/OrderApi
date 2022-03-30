using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public interface IOrderRepository
    {
        Task<bool> AddOrder(OrderHeader orderHeader);
        Task UpdateOrderPaymentStatu(int orderHederId,bool paid);
    }
}
