using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.Core.Entities;
using YamanerECommerce.Application.Features.CQRS.Commands.CartCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.OrderItemCommands;
using YamanerECommerce.Application.Features.CQRS.Commands.ProductCommands;
using YamanerECommerce.Application.Interfaces;

namespace YamanerECommerce.Application.Features.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly IRepository<Product> _repository;

        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateProductCommand
            command)
        {
            await _repository.CreateAsync(new Product

            {

                Barcode = command.Barcode,
                CostPrice = command.CostPrice,
                BrandCode = command.BrandCode,
                SalePrice = command.SalePrice,
                BrandDescription = command.BrandDescription,
                Gender = command.Gender,
                GenderDescription = command.GenderDescription,
                ColorCode = command.ColorCode,
                ColorDescription = command.ColorDescription,
                Inventory = command.Inventory,
                Kavala = command.Kavala,
                ProductCode = command.ProductCode,
                ProductFeature = command.ProductFeature,
                ProductFeatureDescription = command.ProductFeatureDescription,
                ProductGroup = command.ProductGroup,
                ProductGroupDescription = command.ProductGroupDescription,
                ProductName = command.ProductName,
                Size = command.Size,




            });


        }
    }
}
