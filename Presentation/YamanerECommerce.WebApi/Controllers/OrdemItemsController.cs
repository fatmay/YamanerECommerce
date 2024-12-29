using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderItemCommands;
using YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers;
using YamanerECommerce.Application.Features.CQRS.Handlers.OrderItemHandlers;
using YamanerECommerce.Application.Features.CQRS.Queries.CartQueries;
using YamanerECommerce.Application.Features.CQRS.Queries.OrderItemQueries;

namespace YamanerECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdemItemsController : ControllerBase
    {
        private readonly  CreateOrderItemCommandHandler _createOrderItemCommandHandler;
        private readonly  GetOrderItemByIdQueryHandler _getOrderItemByIdQueryHandler;
        private readonly GetOrderItemQueryHandler  _getOrderItemQueryHandler;
        private readonly UpdateOrderItemCommandHandeler _updateOrderItemCommandHandeler;
        private readonly RemoveOrderItemCommandHandler _removeOrderItemCommandHandler;

        public OrdemItemsController(CreateOrderItemCommandHandler createOrderItemCommandHandler, 
            GetOrderItemByIdQueryHandler getOrderItemByIdQueryHandler, 
            GetOrderItemQueryHandler getOrderItemQueryHandler, 
            UpdateOrderItemCommandHandeler updateOrderItemCommandHandeler, 
            RemoveOrderItemCommandHandler removeOrderItemCommandHandler)
        {
            _createOrderItemCommandHandler = createOrderItemCommandHandler;
            _getOrderItemByIdQueryHandler = getOrderItemByIdQueryHandler;
            _getOrderItemQueryHandler = getOrderItemQueryHandler;
            _updateOrderItemCommandHandeler = updateOrderItemCommandHandeler;
            _removeOrderItemCommandHandler = removeOrderItemCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> CartList()
        {
            var values = await _getOrderItemQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderItem(int id)
        {
            var value = await _getOrderItemByIdQueryHandler.Handle(new GetOrderItemByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrderItem(CreateOrderItemCommand command)
        {
            await _createOrderItemCommandHandler.Handle(command);
            return Ok("orderıtem bilgisi eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveOrderItem(int id)
        {
            await _removeOrderItemCommandHandler.Handle(new RemoveOrderItemCommand(id));
            return Ok("orderıtem bilgisi silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrderItem(UpdateOrderItemCommand command)
        {
            await _updateOrderItemCommandHandeler.Handle(command);
            return Ok("orderıtem bilgisi güncellendi");

        }
    }
}
