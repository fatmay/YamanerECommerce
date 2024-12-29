using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Queries.OrderItemQueries;
using YamanerECommerce.Application.Features.CQRS.Queries.OrderQueries;
using YamanerECommerce.Application.Features.CQRS.Results.OrderResults;
using YamanerECommerce.Application.Features.CQRS.Results.OrdetItem;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.OrderItemHandlers
{
    public class GetOrderItemByIdQueryHandler
    {
        private readonly IRepository<OrderItem> _repository;

        public GetOrderItemByIdQueryHandler(IRepository<OrderItem> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderItemByIdQueryResult> Handle(GetOrderItemByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetOrderItemByIdQueryResult
            {
                Id=values.Id,
                OrderId=values.OrderId,
                Price=values.Price,
                ProductId=values.ProductId,
                Quantity=values.Quantity


            };
        }
    }
}
