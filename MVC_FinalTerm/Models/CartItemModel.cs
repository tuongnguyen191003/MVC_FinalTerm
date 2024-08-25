﻿using System.ComponentModel.DataAnnotations;

namespace MVC_FinalTerm.Models
{
    public class CartItemModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public decimal Discount { get; set; } = 0;
        public decimal Total
        {
            get { return Quantity * Price; }
        }
        public CartItemModel() { }
        public CartItemModel(ProductModel product)
        {
            ProductId = product.Id;
            ProductName = product.Name;
            Price = product.Price;
            Quantity = 1;
            Image = product.Image;
        }


    }
}
