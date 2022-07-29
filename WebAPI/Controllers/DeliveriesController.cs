using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        IDeliveryService _deliveryService;

        public DeliveriesController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }
        [HttpGet("getall")]
        [Authorize(Roles = "GetDelivery")]
        public IActionResult GetAll()
        {
            var result = _deliveryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deliveryenter")]
        [Authorize(Roles = "deliveryenter")]
        public IActionResult DeliveryEnter(Delivery delivery)
        {
            var result = _deliveryService.DeliveryEnter(delivery);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deliveryhandover")]
        [Authorize(Roles = "deliveryhandover")]
        public IActionResult DeliveryHandOver(int id)
        {
            var result = _deliveryService.DeliveryHandOver(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deliverytake")]
        [Authorize(Roles = "deliverytake")]

        public IActionResult DeliveryTake(int id)
        {
            var result = _deliveryService.DeliveryTake(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
