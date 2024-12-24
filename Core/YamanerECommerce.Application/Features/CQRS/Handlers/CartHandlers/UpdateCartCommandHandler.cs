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
    public class UpdateCartCommandHandler
    {
        private readonly IRepository<Cart> _repository;

        public UpdateCartCommandHandler(IRepository<Cart> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCartCommand command)
        {
            var values=await _repository.GetByIdAsync(command.Id);
            values.UserId=command.UserId;
        }
    }
}
