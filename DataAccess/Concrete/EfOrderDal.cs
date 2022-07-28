using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class EfOrderDal : EfEntityRepositoryBase<DeliverySystemDb, Order>, IOrderDal
    {
        public Order GetOrderByDateTime(DateTime dateTime)
        {
            using (DeliverySystemDb db = new DeliverySystemDb())
            {
                return db.Set<Order>().Where(x => x.OrderDate == dateTime).FirstOrDefault();
            }
        }
    }
}
