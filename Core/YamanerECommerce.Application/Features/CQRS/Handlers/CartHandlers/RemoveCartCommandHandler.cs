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
    public class RemoveCartCommandHandler
    {
        private readonly IRepository <Cart> _repository;

        public RemoveCartCommandHandler(IRepository<Cart> repository)
        {
            _repository = repository;
        }
        public async Task Handle (RemoveCartCommand command)
        {
            var value=await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
