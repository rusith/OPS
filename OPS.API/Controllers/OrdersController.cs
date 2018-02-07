using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OPS.API.Models;
using OPS.Models.Data;
using OPS.Services.Business;

namespace OPS.API.Controllers
{
  [Route("api/orders")]
  public class OrdersController : Controller
  {
    private readonly IOrderService _orderService;
    public OrdersController(IOrderService orderService)
    {
      _orderService = orderService;
    }

    [HttpGet, Route("{id:int}")]
    public async Task<IOrder> Get(int id)
    {
      return await _orderService.GetOrder(id);
    }

    [HttpPost]
    public async void Post([FromBody] OrderModel model)
    {
      await _orderService.AddOrderAsync(model.Remarks, model.Quantity);
    }

    [HttpDelete("{id}")]
    public async Task<IOrder> Delete(int id)
    {
      return await _orderService.RemoveOrder(id);
    }
  }
}
