using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Queries.CartItemQueries;
using YamanerECommerce.Application.Features.CQRS.Queries.CartQueries;
using YamanerECommerce.Application.Features.CQRS.Results.CartItemResults;
using YamanerECommerce.Application.Features.CQRS.Results.CartResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers
{
    public class GetCartItemByIdQueryHandler
    {
        private readonly IRepository<CartItem> _repository;

        public GetCartItemByIdQueryHandler(IRepository<CartItem> repository)
        {
            _repository = repository;
        }

        public async Task<GetCartItemByIdQueryResult> Handle(GetCartItemByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCartItemByIdQueryResult
            {
                CartId = values.CartId,
                Id = values.Id,
                ProductId=values.ProductId,
                Quantity=values.Quantity,

            };
        }
    }
}
