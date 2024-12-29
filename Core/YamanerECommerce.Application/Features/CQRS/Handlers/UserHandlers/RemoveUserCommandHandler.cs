using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderItemCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.UserCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.UserHandlers
{
    public class RemoveUserCommandHandler
    {
        private readonly IRepository<User> _repository;

        public RemoveUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveUserCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }

    }
}
