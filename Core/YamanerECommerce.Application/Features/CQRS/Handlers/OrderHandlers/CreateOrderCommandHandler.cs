using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.OrderHandlers
{
    public class CreateOrderCommandHandler
    {
        private readonly IRepository<Order> _repository;

        public CreateOrderCommandHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateOrderCommand command)
        {
            await _repository.CreateAsync(new Order

            {
                UserId = command.UserId,
                OrderDate = command.OrderDate,
                TotalAmount = command.TotalAmount,
                Status = command.Status

            });


        }

    }
}
