

using Microsoft.AspNetCore.Mvc;
using wawa_api.Models;
using wawa_api.Resources;
using wawa_api.Services;

namespace wawa_api.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {

        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public Order postOrder()
        {

            Order temp = _orderService.createNew();
            return temp;
        }
    }
}