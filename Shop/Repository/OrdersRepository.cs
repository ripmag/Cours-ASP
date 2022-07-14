using Shop.Interfaces;
using Shop.Models;

namespace Shop.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent content;
        private readonly ShopCard shopCart;
        public OrdersRepository(AppDBContent content, ShopCard shopCart)
        {
            this.content = content;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = System.DateTime.Now;
            content.Order.Add(order);
            content.SaveChanges();

            var items = shopCart.ListShopItems;
            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    CarID = el.Car.Id,
                    OrderId = order.Id,
                    Price = el.Car.Price
                };
                content.OrderDetail.Add(orderDetail);
                
            }
            content.SaveChanges();
        }
    }
}
