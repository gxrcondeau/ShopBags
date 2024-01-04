namespace ShopBags.Models
{
    public class Bag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SizeId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
    }
}
