using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.UserCommands;
using YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers;
using YamanerECommerce.Application.Features.CQRS.Handlers.UserHandlers;
using YamanerECommerce.Application.Features.CQRS.Queries.CartQueries;
using YamanerECommerce.Application.Features.CQRS.Queries.UserQueries;

namespace YamanerECommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly CreateUserCommandHandler _createUserCommandHandler;
        private readonly GetUserByIdQueryHandler _getUserByIdQueryHandler;
        private readonly GetUserQueryHandler _getUserQueryHandler;
        private readonly UpdateUserCommandHandler _updateUserCommandHandler;
        private readonly RemoveUserCommandHandler _removeUserCommandHandler;

        public UsersController(CreateUserCommandHandler createUserCommandHandler, 
            GetUserByIdQueryHandler getUserByIdQueryHandler, 
            GetUserQueryHandler getUserQueryHandler, 
            UpdateUserCommandHandler updateUserCommandHandler, 
            RemoveUserCommandHandler removeUserCommandHandler)
        {
            _createUserCommandHandler = createUserCommandHandler;
            _getUserByIdQueryHandler = getUserByIdQueryHandler;
            _getUserQueryHandler = getUserQueryHandler;
            _updateUserCommandHandler = updateUserCommandHandler;
            _removeUserCommandHandler = removeUserCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            var values = await _getUserQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var value = await _getUserByIdQueryHandler.Handle(new GetUserByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            await _createUserCommandHandler.Handle(command);
            return Ok("user bilgisi eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveUser(int id)
        {
            await _removeUserCommandHandler.Handle(new RemoveUserCommand(id));
            return Ok("user bilgisi silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand command)
        {
            await _updateUserCommandHandler.Handle(command);
            return Ok("user bilgisi güncellendi");

        }
    }
}

