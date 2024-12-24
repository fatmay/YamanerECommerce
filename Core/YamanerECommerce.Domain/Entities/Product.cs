using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceProject.ECommerceProject.Core.Entities;

namespace ECommerceProject.Core.Entities
{
    public class Product
    {
        public int Id { get; set; } // Birincil anahtar
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

        // Relationships
        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Season> Seasons { get; set; }
        public ICollection<Discount> Discounts { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
