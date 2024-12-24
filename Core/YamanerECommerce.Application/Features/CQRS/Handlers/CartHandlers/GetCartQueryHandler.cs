using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Results.CartResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.CartHandlers
{
    public class GetCartQueryHandler
    {
        private readonly IRepository<Cart> _repository;
            public GetCartQueryHandler(IRepository<Cart> repository)
        {
            _repository = repository;

        }
        public async Task <List<GetCartQueryResult>>Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetCartQueryResult
            {       Id=x.Id,
                    UserId=x.UserId,

            } ).ToList();
        }
    }
}
