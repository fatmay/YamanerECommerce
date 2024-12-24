using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Results.CartResults
{
    public class GetCartQueryResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
