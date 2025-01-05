using ECommerceProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamanerECommerce.Application.Features.CQRS.Results.StockResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.StockHandlers
{
    public class GetStockQueryHandler
    {
        private readonly IRepository<Stock> _repository;

        public GetStockQueryHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }
        public async Task <List<GetStockQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetStockQueryResult
            {
                Id = x.Id,
                ProductId = x.ProductId,
                WarehouseId = x.WarehouseId,
                Quantity = x.Quantity,
            }).ToList();
        }
    }
}
