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
    public class UpdateStockCommandHandler
    {
        private readonly IRepository<Stock> repository;

        public UpdateStockCommandHandler(IRepository<Stock> repository)
        {
            this.repository = repository;
        }
        public async Task Handle(UpdateStockCommand command)
        {
            var values = await repository.GetByIdAsync(command.Id);
            values.ProductId = command.ProductId;
            values.WarehouseId = command.WarehouseId;
            values.Quantity = command.Quantity;
            await _repository.UpdateAsync(values);
        }
    }
}
