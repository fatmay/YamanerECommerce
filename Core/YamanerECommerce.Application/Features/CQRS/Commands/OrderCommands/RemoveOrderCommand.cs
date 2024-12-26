using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Commands.OrderCommands
{
    public class RemoveOrderCommand
    {
        public int Id { get; set; }

        public RemoveOrderCommand(int id)
        {
            id = id;
        }
    }
}
