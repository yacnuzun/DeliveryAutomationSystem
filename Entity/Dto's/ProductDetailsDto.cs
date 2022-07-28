using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto_s
{
    public class ProductDetailsDto : IDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
