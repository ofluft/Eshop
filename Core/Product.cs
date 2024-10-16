﻿
namespace Eshop.Core
{
    public class Product
    {
        public int Id;
        public string Name;
        public decimal Price;
        public int Stock;
        public ProductCategory Category;

        public Product(int id, string name, decimal price, int stock, ProductCategory category)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            Category = category;
        }

        public override string? ToString()
        {
            return $"Товар: {Name}.\nКатегория: {Category}.\nСтоимость: {Price}.";
        }
    }
}
