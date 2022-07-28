using Core.Utilities.Results;
using Entity.Concrete;
using Entity.Dto_s;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IResult AddOrder(Order order, List<ProductDetailsDto> productDetailsDto);
    }
}
