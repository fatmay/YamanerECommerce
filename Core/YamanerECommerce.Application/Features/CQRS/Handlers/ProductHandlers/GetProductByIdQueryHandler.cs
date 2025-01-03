using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Queries.OrderItemQueries;
using YamanerECommerce.Application.Features.CQRS.Queries.ProductQueries;
using YamanerECommerce.Application.Features.CQRS.Results.OrdetItem;
using YamanerECommerce.Application.Features.CQRS.Results.ProductResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly IRepository<Product> _repository;

        public GetProductByIdQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetProductByIdQueryResult
            {
                Size = values.Size,
                SalePrice = values.SalePrice,
                Barcode = values.Barcode,
                BrandCode = values.BrandCode,
                BrandDescription = values.BrandDescription,
                ColorCode = values.ColorCode,
                ColorDescription = values.ColorDescription,
                CostPrice = values.CostPrice,
                Gender = values.Gender,
                GenderDescription = values.GenderDescription,
                Inventory = values.Inventory,
                Kavala = values.Kavala,
                ProductCode = values.ProductCode,
                ProductFeature = values.ProductFeature,
                ProductFeatureDescription = values.ProductFeatureDescription,
                ProductGroup = values.ProductGroup,
                ProductGroupDescription = values.ProductGroupDescription,
                ProductName = values.ProductName,
                

            };
        }
    }
}
