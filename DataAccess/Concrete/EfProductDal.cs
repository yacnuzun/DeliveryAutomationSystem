using Core.DataAccess.EntityFramework;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class EfProductDal : EfEntityRepositoryBase<DeliverySystemDb, Product>
    {
    }
}
