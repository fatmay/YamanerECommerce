using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Core.Entities
{
    public class Warehouse
    {
        public int Id { get; set; } // Birincil anahtar
        public string WarehouseCode { get; set; } // Depo Kodu
        public string WarehouseName { get; set; } // Depo Adı

        // Relationships
        public ICollection<Stock> Stocks { get; set; }
    }
}
