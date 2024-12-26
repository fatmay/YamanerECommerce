using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderCommands;
using YamanerECommerce.Application.Features.CQRS.Queries.OrderQueries;
using YamanerECommerce.Application.Features.CQRS.Results.OrderResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.OrderHandlers
{
    public class RemoveOrderCommandHandler
    {
        private readonly IRepository<Order> _repository;

        public RemoveOrderCommandHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveOrderCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);

        }
    }
}
