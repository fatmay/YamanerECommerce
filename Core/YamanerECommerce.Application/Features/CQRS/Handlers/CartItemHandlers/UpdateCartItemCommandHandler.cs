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
    public class UpdateCartItemCommandHandler
    {
        private readonly IRepository<CartItem> _repository;

        public UpdateCartItemCommandHandler(IRepository<CartItem> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCartItemCommand command)
        {
            var values=await _repository.GetByIdAsync(command.Id);
            values.Quantity = command.Quantity;
            values.ProductId = command.ProductId;
            values.CartId = command.CartId;
            await _repository.UpdateAsync(values);
        }
    }
}
