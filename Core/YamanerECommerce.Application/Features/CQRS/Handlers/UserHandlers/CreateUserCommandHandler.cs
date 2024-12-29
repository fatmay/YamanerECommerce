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
    public class CreateUserCommandHandler
    {
        private readonly IRepository<User> _repository;

        public CreateUserCommandHandler(IRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateUserCommand
            command)
        {
            await _repository.CreateAsync(new User

            {
                Password=command.Password,
                FirstName=command.FirstName,
                LastName=command.LastName,
                Email=command.Email,
                PhoneNumber=command.PhoneNumber,
                Role=command.Role,

            });


        }
    }
}
