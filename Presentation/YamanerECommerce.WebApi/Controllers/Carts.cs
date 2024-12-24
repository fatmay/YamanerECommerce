using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers;
using YamanerECommerce.Application.Features.CQRS.Queries.CartQueries;

namespace YamanerECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Carts : ControllerBase
    {
        private readonly CreateCartCommandHandler _createCartCommandHandler;
        private readonly GetCartByIdQueryHandler _getCartByIdQueryHandler;
        private readonly GetCartQueryHandler _getCartQueryHandler;
        private readonly UpdateCartCommandHandler _updateCartCommandHandler;
        private readonly RemoveCartCommandHandler _removeCartCommandHandler;

        public Carts(CreateCartCommandHandler createCartCommandHandler, 
            GetCartByIdQueryHandler getCartByIdQueryHandler, 
            GetCartQueryHandler getCartQueryHandler, 
            UpdateCartCommandHandler updateCartCommandHandler,
            RemoveCartCommandHandler removeCartCommandHandler)
        {
            _createCartCommandHandler = createCartCommandHandler;
            _getCartByIdQueryHandler = getCartByIdQueryHandler;
            _getCartQueryHandler = getCartQueryHandler;
            _updateCartCommandHandler = updateCartCommandHandler;
            _removeCartCommandHandler = removeCartCommandHandler;
        }
        [HttpGet]
        public async Task <IActionResult> CartList()
        {
            var values = await _getCartQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> GetCart (in id)
        {
            var value = await _getCartByIdQueryHandler.Handle(new GetCartByIdQuery)
        }
    }
}
