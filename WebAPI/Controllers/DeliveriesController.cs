﻿using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : Controller
    {
        IDeliveryService _deliveryService;

        public DeliveriesController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _deliveryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //[Authorize(Roles = "DeliveryEnter")]

        [HttpPost("deliveryenter")]
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