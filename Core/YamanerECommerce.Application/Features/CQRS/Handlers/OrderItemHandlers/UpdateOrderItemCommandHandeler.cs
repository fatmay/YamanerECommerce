using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderItemCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.OrderItemHandlers
{
    public class UpdateOrderItemCommandHandeler
    {
        private readonly IRepository<OrderItem> _repository;

        public UpdateOrderItemCommandHandeler(IRepository<OrderItem> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateOrderItemCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            values.OrderId = command.OrderId;
            values.Quantity = command.Quantity;
            values.Price = command.Price;
            values. ProductId = command.ProductId;
            await _repository.UpdateAsync(values);
        }
    }
}
