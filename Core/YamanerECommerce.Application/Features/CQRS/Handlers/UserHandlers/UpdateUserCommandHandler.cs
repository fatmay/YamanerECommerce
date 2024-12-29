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
    public class UpdateUserCommandHandler
    {
        private readonly IRepository<User> _repository;

        public UpdateUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateUserCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            values.PhoneNumber = command.PhoneNumber;
            values.LastName = command.LastName;
            values.FirstName = command.FirstName;
            values.Email = command.Email;
            values.Role = command.Role;
            values.Password = command.Password;


            await _repository.UpdateAsync(values);

        }
    }
}
