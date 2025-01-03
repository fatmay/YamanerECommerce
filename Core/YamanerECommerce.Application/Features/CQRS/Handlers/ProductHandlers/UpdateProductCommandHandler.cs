using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.ProductCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class UpdateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateProductCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.Inventory = command.Inventory;
            values.Kavala = command.Kavala;
            values.SalePrice = command.SalePrice;
            values.SalePrice= command.SalePrice;
            values.CostPrice = command.CostPrice;
            values.Barcode = command.Barcode;
            values.ProductGroup = command.ProductGroup;
            values.ProductName = command.ProductName;
            values.ProductFeature = command.ProductFeature;
            values.ProductCode = command.ProductCode;
            values.ProductGroup= command.ProductGroup;
            values.BrandCode= command.BrandCode;
            values.BrandDescription= command.BrandDescription;
            values.ColorDescription= command.ColorDescription;
            values.ColorCode= command.ColorCode;
            values.Inventory= command.Inventory;
            values.Gender= command.Gender;
            values.GenderDescription= command.GenderDescription;

            await _repository.UpdateAsync(values);
        }

    }
}
