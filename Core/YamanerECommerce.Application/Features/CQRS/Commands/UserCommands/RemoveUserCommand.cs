using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Commands.UserCommands
{
    public class RemoveUserCommand
    {
        public int Id { get; set; }
        public RemoveUserCommand(int id)
        {
            Id = id;
        }
    }
}
