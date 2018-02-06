using System.Collections.Generic;
using wawa_api.Models;

namespace wawa_api.Resources
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext _orderContext;

        public OrderRepository(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }

        public IEnumerable<Order> findAll()
        {
            return _orderContext.order;
        }

        public Order save(Order order)
        {
            var temp = new Order
            {
                name = "Bill"
            };

            temp = _orderContext.order.Add(temp).Entity;
            _orderContext.SaveChanges();

            return temp;
        }
    }

    public interface IOrderRepository
    {
        IEnumerable<Order> findAll();
        Order save(Order order);
    }
}