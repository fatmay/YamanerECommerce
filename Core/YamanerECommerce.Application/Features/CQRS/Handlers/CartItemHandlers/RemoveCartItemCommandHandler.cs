using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.CartItemCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers
{
    public class RemoveCartItemCommandHandler
    {
        private readonly IRepository <Cart> _repository;

        public RemoveCartItemCommandHandler(IRepository<Cart> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCartItemCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
