using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Queries.CartQueries;
using YamanerECommerce.Application.Features.CQRS.Results.CartResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers
{
    public class GetCartByIdQueryHandler
    {
        private readonly IRepository<Cart> _repository;

        public GetCartByIdQueryHandler(IRepository<Cart> repository)
        {
            _repository = repository;
        }
        public async Task<GetCartByIdQueryResult> Handle(GetCartByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetCartByIdQueryResult
            {
                Id = values.Id,
                UserId = values.UserId,

            };
        }
    }
}
