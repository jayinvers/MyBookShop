namespace MyBookShop.Models.Entities
{
    public class Cart
    {
        public int CartId { get; set; }
        
        public decimal Total { get; set; }
        public decimal Gst { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public List<CartItem> CartItems { get; set; }

    }
}
