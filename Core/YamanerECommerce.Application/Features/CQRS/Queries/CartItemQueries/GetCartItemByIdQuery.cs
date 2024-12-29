using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Queries.CartItemQueries
{
    public class GetCartItemByIdQuery
    {
        public GetCartItemByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
