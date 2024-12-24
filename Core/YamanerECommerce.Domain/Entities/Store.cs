using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Core.Entities
{
    public class Store
    {
        public int Id { get; set; } // Birincil anahtar
        public string StoreCode { get; set; } // Mağaza Kodu
        public string StoreName { get; set; } // Mağaza Adı

        // Relationships
        public ICollection<Product> Products { get; set; }
    }
}
