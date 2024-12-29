using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using YamanerECommerce.Application.Features.CQRS.Commands.CartItemCommands;
using YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers;
using YamanerECommerce.Application.Features.CQRS.Handlers.CartItemHandlers;
using YamanerECommerce.Application.Features.CQRS.Queries.CartItemQueries;


namespace YamanerECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        private readonly CreateCartItemCommandHandler _createCartItemCommandHandler;
        private readonly GetCartItemByIdQueryHandler _getCartItemByIdQueryHandler;
        private readonly GetCartItemQueryHandler _getCartItemQueryHandler;
        private readonly UpdateCartItemCommandHandler _updateCartItemCommandHandler;
        private readonly RemoveCartItemCommandHandler _removeCartItemCommandHandler;

        public CartItemsController(CreateCartItemCommandHandler createCartItemCommandHandler, 
            GetCartItemByIdQueryHandler getCartItemByIdQueryHandler, 
            GetCartItemQueryHandler getCartItemQueryHandler, 
            UpdateCartItemCommandHandler updateCartItemCommandHandler, 
            RemoveCartItemCommandHandler removeCartItemCommandHandler)
        {
            _createCartItemCommandHandler = createCartItemCommandHandler;
            _getCartItemByIdQueryHandler = getCartItemByIdQueryHandler;
            _getCartItemQueryHandler = getCartItemQueryHandler;
            _updateCartItemCommandHandler = updateCartItemCommandHandler;
            _removeCartItemCommandHandler = removeCartItemCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CartItemList()
        {
            var values = await _getCartItemQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartItem(int id)
        {
            var value = await _getCartItemByIdQueryHandler.Handle(new GetCartItemByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCartItem(CreateCartItemCommand command)
        {
            await _createCartItemCommandHandler.Handle(command);
            return Ok("cart bilgisi eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCartItem(int id)
        {
            await _removeCartItemCommandHandler.Handle(new RemoveCartItemCommand (id));
            return Ok("cart bilgisi silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCartItem(UpdateCartItemCommand command)
        {
            await _updateCartItemCommandHandler.Handle(command);
            return Ok("cart bilgisi güncellendi");

        }
    }
}
