using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderItemCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.OrderItemHandlers
{
    public class CreateOrderItemCommandHandler
    {
        private readonly IRepository <OrderItem> _repository;

        public CreateOrderItemCommandHandler(IRepository<OrderItem> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateOrderItemCommand
            command)
        {
            await _repository.CreateAsync(new OrderItem

            {
                OrderId = command.OrderId,
                Price = command.Price,
                ProductId = command.ProductId,
                Quantity = command.Quantity




            });


        }
    }

}
