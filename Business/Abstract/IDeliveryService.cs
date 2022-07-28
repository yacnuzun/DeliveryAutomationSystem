using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDeliveryService
    {
        IDataResult<List<Delivery>> GetAll();
        IResult DeliveryEnter(Delivery delivery);
        IResult DeliveryTake(int id);
        IResult DeliveryHandOver(int id);

    }
}
