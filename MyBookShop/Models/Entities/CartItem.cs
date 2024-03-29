﻿namespace MyBookShop.Models.Entities
{
    public class CartItem
    {
        public int CartItemId { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
