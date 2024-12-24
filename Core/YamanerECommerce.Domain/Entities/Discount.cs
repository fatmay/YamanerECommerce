using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Core.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public float Percentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Relationships
        public ICollection<Product> Products { get; set; }
    }
}
