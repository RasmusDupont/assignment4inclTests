using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4
{
    public class Order
    {
        [Column("OrderId")]
        public int Id { get; set; }
        [Column("OrderDate")]
        public DateTime Date { get; set; }
        public DateTime RequiredDate { get; set; }
        public Nullable<DateTime> ShippedDate { get; set; }
        public double Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipCity { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
