namespace ShopBags.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BagId { get; set; }
        public int StatusId { get; set; }
    }
}
