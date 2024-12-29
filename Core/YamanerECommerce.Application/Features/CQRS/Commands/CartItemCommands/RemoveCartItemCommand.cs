using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Commands.CartItemCommands
{
    public class RemoveCartItemCommand
    {
        public int Id { get; set; }

        public RemoveCartItemCommand(int id)
        {
            Id = id;
        }

    }
}
