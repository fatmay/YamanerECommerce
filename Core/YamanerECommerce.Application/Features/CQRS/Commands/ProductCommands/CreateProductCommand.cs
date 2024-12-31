using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamanerECommerce.Application.Features.CQRS.Commands.ProductCommands
{
    public class CreateProductCommand
    {
      
        public string Barcode { get; set; } // Barkod
        public float CostPrice { get; set; } // Maliyet Fiyatı
        public float SalePrice { get; set; } // Satış Fiyatı
        public string GenderDescription { get; set; } // Cinsiyet Açıklması
        public string Gender { get; set; } // Cinsiyet 

        public string BrandDescription { get; set; } // Marka Açıklama
        public string BrandCode { get; set; } // Marka

        public string ProductName { get; set; } // ürün Adı
        public string ProductCode { get; set; } // ÜrünKodu
        public string ProductGroup { get; set; } // Ürün Gurubu
        public string ProductGroupDescription { get; set; } // Ürün Gurubu Açıklama
        public string ProductFeature { get; set; } // Ürün Özellikler 
        public string ProductFeatureDescription { get; set; } // Ürün Özellilkler Açıklaması+-
        public string ColorCode { get; set; } // Renk
        public string ColorDescription { get; set; } // Renk Açıklaması
        public string Size { get; set; } // Beden
        public string Inventory { get; set; } // Envanter
        public string Kavala { get; set; } // Kavala
    }
}
