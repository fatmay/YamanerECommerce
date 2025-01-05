using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YamanerECommerce.Application.Features.CQRS.Commands.StockCommands;
using YamanerECommerce.Application.Features.CQRS.Handlers.StockHandlers;
using YamanerECommerce.Application.Features.CQRS.Queries.StockQueries;

namespace YamanerECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoksController : ControllerBase
    {
        private readonly CreateStockCommandHandler _createStockCommandHandler;
        private readonly GetStockByIdQueryHandler _getStockByIdQueryHandler;
        private readonly GetStockQueryHandler _getStockQueryHandler;
        private readonly UpdateStockCommandHandler _updateStockCommandHandler;
        private readonly RemoveStockCommandHandler _removeStockCommandHandler;

        public StoksController(CreateStockCommandHandler createStockCommandHandler, GetStockByIdQueryHandler getStockByIdQueryHandler, GetStockQueryHandler getStockQueryHandler, UpdateStockCommandHandler updateStockCommandHandler, RemoveStockCommandHandler removeStockCommandHandler)
        {
            _createStockCommandHandler = createStockCommandHandler;
            _getStockByIdQueryHandler = getStockByIdQueryHandler;
            _getStockQueryHandler = getStockQueryHandler;
            _updateStockCommandHandler = updateStockCommandHandler;
            _removeStockCommandHandler = removeStockCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> StockList()
        {
            var values = await _getStockQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStock(int id)
        {
            var values = await _getStockByIdQueryHandler.Handle(new GetStockByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateStock(CreateStockCommand command)
        {
            await _createStockCommandHandler.Handle(command);
            return Ok("Stok Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveStock(int id)
        {
            await _removeStockCommandHandler.Handle(new RemoveStockCommand(id));
            return Ok("Stok Bilgisi Silindi.");
        }
        [HttpPut]
        public async Task <IActionResult> UpdateStock(UpdateStockCommand command)
        {
            await _updateStockCommandHandler.Handle(command);
            return Ok("Stok Bilgisi Güncellendi.");
        }
    }
}
