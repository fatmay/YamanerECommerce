using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YamanerECommerce.Application.Features.CQRS.Commands.ProductCommands;
using YamanerECommerce.Application.Features.CQRS.Handlers.ProductHandlers;
using YamanerECommerce.Application.Features.CQRS.Queries.ProductQueries;


namespace YamanerECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly  GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;

        public ProductController(CreateProductCommandHandler createProductCommandHandler, 
            GetProductByIdQueryHandler getProductByIdQueryHandler, 
            GetProductQueryHandler getProductQueryHandler,
            RemoveProductCommandHandler removeProductCommandHandler, 
            UpdateProductCommandHandler updateProductCommandHandler)
        {
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _getProductQueryHandler = getProductQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _getProductQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var value = await _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            await _createProductCommandHandler.Handle(command);
            return Ok("ürün bilgisi eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            await _removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return Ok("ürün bilgisi silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _updateProductCommandHandler.Handle(command);
            return Ok("ürün bilgisi güncellendi");

        }
    }
}
