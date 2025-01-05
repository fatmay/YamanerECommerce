using ECommerceProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamanerECommerce.Application.Features.CQRS.Queries.StockQueries;
using YamanerECommerce.Application.Features.CQRS.Results.StockResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.StockHandlers
{
    public class GetStockByIdQueryHandler
    {
        private readonly IRepository<Stock> _repository;

        public GetStockByIdQueryHandler(IRepository<Stock> repository)
        {
            _repository = repository;
        }
        public async Task <GetStockByIdQueryResult> Handle(GetStockByIdQuery query)
        {
            var values =await _repository.GetByIdAsync(query.Id);
            return new GetStockByIdQueryResult
            {
                Id = values.Id,
                ProductId= values.ProductId,
                WarehouseId= values.WarehouseId,
                Quantity = values.Quantity,

            };
        }
     
    }
}
