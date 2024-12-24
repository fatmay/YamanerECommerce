using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Queries.CartQueries
{
    public class GetCartByIdQuery
    {
        public GetCartByIdQuery(int id)
        {
            Id=id;
        }
        public int Id { get; set; }
    }
}
