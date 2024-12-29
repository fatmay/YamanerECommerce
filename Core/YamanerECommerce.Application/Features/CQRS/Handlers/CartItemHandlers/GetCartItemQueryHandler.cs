using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Results.CartItemResults;
using YamanerECommerce.Application.Features.CQRS.Results.CartResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers
{
    public class GetCartItemQueryHandler
    {
        private readonly IRepository<CartItem> _repository;

        public GetCartItemQueryHandler(IRepository<CartItem> repository)
        {
            this._repository = repository;
        }

        public async Task <List<GetCartItemQueryResult>>Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetCartItemQueryResult
            {     
                Quantity = x.Quantity,
                ProductId = x.ProductId,
                Id = x.Id,
                CartId = x.CartId   
           

            } ).ToList();
        }
    }
}
