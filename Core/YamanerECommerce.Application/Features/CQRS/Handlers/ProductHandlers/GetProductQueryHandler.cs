using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Results.OrdetItem;
using YamanerECommerce.Application.Features.CQRS.Results.ProductResults;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly IRepository<Product> _repository;

        public GetProductQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetProductQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetProductQueryResult
            {
                Barcode = x.Barcode,
                BrandCode = x.BrandCode,
                BrandDescription = x.BrandDescription,
                ColorCode = x.ColorCode,
                ColorDescription = x.ColorDescription,
                CostPrice = x.CostPrice,
                Gender = x.Gender,
                GenderDescription = x.GenderDescription,
                Id = x.Id,
                Inventory = x.Inventory,
                Kavala = x.Kavala,
                ProductCode = x.ProductCode,
                ProductFeature = x.ProductFeature,
                ProductFeatureDescription = x.ProductFeatureDescription,
                ProductGroup = x.ProductGroup,
                ProductName = x.ProductName,
                ProductGroupDescription = x.ProductGroupDescription,
                SalePrice = x.SalePrice,
                Size= x.Size,
                

            }).ToList();
        }
    }
}
