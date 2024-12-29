using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.CartItemCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.CartItemHandlers
{
    public class CreateCartItemCommandHandler
    {
        private readonly IRepository<CartItem> _repository;

        public CreateCartItemCommandHandler(IRepository<CartItem> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCartItemCommand command)
        {
            await _repository.CreateAsync(new CartItem

            {

                CartId = command.CartId,
                ProductId = command.ProductId,
                Quantity = command.Quantity,
            }
             );


        }
    }
}
