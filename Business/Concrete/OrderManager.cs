using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Dto_s;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        IOrderProductDal _orderProductDal;
        public OrderManager(IOrderDal orderDal, IOrderProductDal orderProductDal)
        {
            _orderDal = orderDal;
            _orderProductDal = orderProductDal;
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.OrderGet);
        }

        public IResult AddOrder(Order order, List<ProductDetailsDto> productDetailsDto)
        {
            _orderDal.Add(order);
            order.OrderId = GetLastOrder(order.OrderDate);
            AddOrderProducts(productDetailsDto, order.OrderId);
            return new SuccesResult(Messages.OrderGive);
        }
        private void AddOrderProducts(List<ProductDetailsDto> products, int orderId)
        {
            OrderProduct orderProduct;
            foreach (var item in products)
            {
                orderProduct = new OrderProduct()
                {
                    OrderId = orderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };
                _orderProductDal.Add(orderProduct);
            }
        }
        private int GetLastOrder(DateTime orderDate)
        {
            var result = _orderDal.GetOrderByDateTime(orderDate);
            return result.OrderId;
        }
    }
}
