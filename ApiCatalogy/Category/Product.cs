namespace ApiCatalogy.Category
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Nome { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? ImageUrl { get; set; }   
        public float Estock { get; set; }
        public DateTime DateSignin { get; set; }    
        public Categorys? Category { get; set; }
    }
}
