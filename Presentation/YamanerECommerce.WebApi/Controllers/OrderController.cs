using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderCommands;
using YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers;
using YamanerECommerce.Application.Features.CQRS.Handlers.OrderHandlers;
using YamanerECommerce.Application.Features.CQRS.Queries.CartQueries;
using YamanerECommerce.Application.Features.CQRS.Queries.OrderQueries;

namespace YamanerECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Order : ControllerBase
    {
        private readonly GetOrderQueryHandler _getOrderQueryHandler;
        private readonly GetOrderByIdQueryHandler _getOrderByIdQueryHandler;
        private readonly CreateOrderCommandHandler _createOrderCommandHandler;  
        private readonly UpdateOrderCommandHandler _updateOrderCommandHandler;
        private readonly RemoveOrderCommandHandler _removeOrderCommandHandler;

        public Order(GetOrderQueryHandler getOrderQueryHandler, 
            GetOrderByIdQueryHandler getOrderByIdQueryHandler, 
            CreateOrderCommandHandler createOrderCommandHandler, 
            UpdateOrderCommandHandler updateOrderCommandHandler, 
            RemoveOrderCommandHandler removeOrderCommandHandler)
        {
            _getOrderQueryHandler = getOrderQueryHandler;
            _getOrderByIdQueryHandler = getOrderByIdQueryHandler;
            _createOrderCommandHandler = createOrderCommandHandler;
            _updateOrderCommandHandler = updateOrderCommandHandler;
            _removeOrderCommandHandler = removeOrderCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> OrderList()
        {
            var values = await _getOrderQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var value = await _getOrderByIdQueryHandler.Handle(new GetOrderByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand command)
        {
            await _createOrderCommandHandler.Handle(command);
            return Ok("bilgi eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveOrder(int id)
        {
            await _removeOrderCommandHandler.Handle(new RemoveOrderCommand(id));
            return Ok("bilgi silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrder(UpdateOrderCommand command)
        {
            await _updateOrderCommandHandler.Handle(command);
            return Ok("bilgi güncellendi");

        }
    }
}
