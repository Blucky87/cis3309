using wawa_api.Models;
using wawa_api.Resources;

namespace wawa_api.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepo;

        public OrderService(IOrderRepository orderRepo)
        {
            _orderRepo = orderRepo;
        }
        
        public Order save(Order order)
        {
            return _orderRepo.save(order);
        } 
        
        public Order createNew()
        {
            return _orderRepo.save(new Order());
        } 
        
        
    }

    public interface IOrderService
    {
        Order createNew();
        Order save(Order order);
    }
}