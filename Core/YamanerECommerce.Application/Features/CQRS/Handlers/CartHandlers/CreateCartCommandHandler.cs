using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers
{
    public class CreateCartCommandHandler
    {
        private readonly IRepository<Cart> _repository;

        public CreateCartCommandHandler(IRepository<Cart> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCartCommand command)
        {
            await _repository.CreateAsync(new Cart

            {
                UserId = command.UserId,

            }
             );


        }
    }
}
