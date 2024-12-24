using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Core.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        // Relationships
        public User User { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
