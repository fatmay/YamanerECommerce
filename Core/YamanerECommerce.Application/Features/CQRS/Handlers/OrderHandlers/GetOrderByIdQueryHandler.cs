using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Queries.OrderQueries;
using YamanerECommerce.Application.Features.CQRS.Results.CartResults;
using YamanerECommerce.Application.Features.CQRS.Results.OrderResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.OrderHandlers
{
    public class GetOrderByIdQueryHandler
    {
        private readonly IRepository<Order> _repository;

        public GetOrderByIdQueryHandler(IRepository<Order> repository)
        {
            _repository = repository;
        }
        public async Task<GetOrderByIdQueryResult> Handle(GetOrderByIdQuery query)
{
    var values = await _repository.GetByIdAsync(query.Id);
    return new GetOrderByIdQueryResult
    {
        Id = values.Id,
        UserId = values.UserId,
        OrderDate = values.OrderDate,
        TotalAmount = values.TotalAmount,
        Status = values.Status,
    };
}
    }
}
