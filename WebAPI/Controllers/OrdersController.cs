using Business.Abstract;
using Entity.Concrete;
using Entity.Dto_s;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class OrdersController : Controller
    {
        IOrderService _orderService;

        public static List<ProductDetailsDto> productDetails = new List<ProductDetailsDto>();
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("addproduct")]
        public IActionResult AddProduct(ProductDetailsDto pDetail)
        {
            productDetails.Add(pDetail);
            if (productDetails.Count() > 0)
            {
                return Ok("Ürün Eklendi.");
            }
            return BadRequest("Ürün Eklenemedi.");
        }

        [HttpPost("addorder")]
        public IActionResult AddOrder(Order order)
        {
            var result = _orderService.AddOrder(order, productDetails);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
