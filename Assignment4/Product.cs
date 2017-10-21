﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4
{
    public class Product
    {
        [Column("ProductId")]
        public int Id { get; set; }
        [Column("ProductName")]
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string QuantityUnit { get; set; }
        public int UnitsInStock { get; set; }
        public Category Category { get; set; }
        public OrderDetail OrderDetails { get; set; }
    }
}
