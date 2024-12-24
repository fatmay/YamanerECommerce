using ECommerceProject.Core.Entities;

namespace ECommerceProject.ECommerceProject.Core.Entities
{
    public class Season
    {
        public string SeasonId { get; set; }
        public string SeasonName { get; set; }
        public string SeasonDescription { get; set; }


        //public Product Product { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
