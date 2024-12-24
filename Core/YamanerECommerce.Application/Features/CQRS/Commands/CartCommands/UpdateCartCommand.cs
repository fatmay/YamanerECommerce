using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Commands.CartCommands
{
    public class UpdateCartCommand
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
