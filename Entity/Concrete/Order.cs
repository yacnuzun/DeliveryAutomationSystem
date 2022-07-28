using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string EndPoint { get; set; }
        public string StartPoint { get; set; }
        public string ContactNumber { get; set; }
    }
}
