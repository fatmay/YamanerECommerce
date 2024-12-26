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
    public class UpdateOrderCommandHandler
    {
        private readonly IRepository<Order> _repository;

        public UpdateOrderCommandHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateOrderCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.UserId = command.UserId;
            values.OrderDate = command.OrderDate;
            values.TotalAmount = command.TotalAmount;
            values.Status = command.Status;
            await _repository.UpdateAsync(values);
        }
    }
}
