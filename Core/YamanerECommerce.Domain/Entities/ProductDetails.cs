using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Core.Entities
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }

        // Relationships
        public Product Product { get; set; }
    }
}
