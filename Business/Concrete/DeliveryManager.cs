using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DeliveryManager : IDeliveryService
    {
        IDeliveryDal _deliveryDal;

        public DeliveryManager(IDeliveryDal deliveryDal)
        {
            _deliveryDal = deliveryDal;
        }

        public IResult DeliveryEnter(Delivery delivery)
        {
            delivery.Status = 0;
            _deliveryDal.Add(delivery);
            return new SuccesResult(Messages.DeliveryAdded);
        }

        public IResult DeliveryHandOver(int id)
        {
            var result = _deliveryDal.Get(d => d.DeliveryId == id);
            result.Status = 1;
            _deliveryDal.Update(result);
            return new SuccesResult(Messages.DeliveryHandOver);
        }

        public IResult DeliveryTake(int id)
        {
            var result = _deliveryDal.Get(d => d.DeliveryId == id);
            result.Status = 2;
            _deliveryDal.Update(result);
            return new SuccesResult(Messages.DeliveryTake);
        }

        public IDataResult<List<Delivery>> GetAll()
        {
            return new SuccessDataResult<List<Delivery>>(_deliveryDal.GetAll(), Messages.DeliveryListed);
        }
    }
}
