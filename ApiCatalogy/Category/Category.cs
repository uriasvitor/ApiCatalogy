using System.Collections.ObjectModel;

namespace ApiCatalogy.Category
{
    public class Categorys
    {

        public Categorys()
        {
            products = new Collection<Product>();
        }
        public int CategorysId { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Product>? products { get; set; }
    }
}
