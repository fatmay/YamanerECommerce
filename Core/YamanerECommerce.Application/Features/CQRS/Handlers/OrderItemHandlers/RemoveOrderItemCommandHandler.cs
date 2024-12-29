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
    public class RemoveOrderItemCommandHandler
    {
        private readonly IRepository <OrderItem> _repository;

        public RemoveOrderItemCommandHandler(IRepository<OrderItem> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveOrderItemCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
