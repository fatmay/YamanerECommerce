using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Commands.CartCommands
{
    public class RemoveCartCommand

    {
        public int Id { get; set; }
      
        public RemoveCartCommand(int id) 
        {
            Id = id;
        }
    }
}
