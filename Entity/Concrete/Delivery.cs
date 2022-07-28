using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Delivery : IEntity
    {
        public int DeliveryId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string VehicleNumber { get; set; }
        public string CargoMan { get; set; }
        public int Status { get; set; }
    }
}
