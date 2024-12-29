using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Results.OrderResults;
using YamanerECommerce.Application.Features.CQRS.Results.OrdetItem;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.OrderItemHandlers
{
    public class GetOrderItemQueryHandler
    {
        private readonly IRepository <OrderItem> _repository;

        public GetOrderItemQueryHandler(IRepository<OrderItem> repository)
        {
            _repository = repository;
        }
        public async Task < List <GetOrderItemQueryResult>> Handle()
        {
            var values= await _repository.GetAllAsync();
                return values.Select(x => new GetOrderItemQueryResult
                {
                    Id = x.Id,
                    OrderId = x.OrderId,
                    Price = x.Price,
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    
                }).ToList();
        }
    }
}
