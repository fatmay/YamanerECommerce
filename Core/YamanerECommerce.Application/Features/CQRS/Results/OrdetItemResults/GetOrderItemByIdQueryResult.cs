using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Results.OrdetItem
{
    public class GetOrderItemByIdQueryResult
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

    }
}
