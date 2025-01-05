using ECommerceProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamanerECommerce.Application.Features.CQRS.Commands.StockCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.StockHandlers
{
    public class CreateStockCommandHandler
    {
        private readonly IRepository<Stock> _repository;

        public CreateStockCommandHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateStockCommand command)
        {
            await _repository.CreateAsync(new Stock
            {
                ProductId = command.ProductId,
                WarehouseId = command.WarehouseId,
                Quantity = command.Quantity,
            });
        }
    }
}
