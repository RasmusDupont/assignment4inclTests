using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Assignment4.Operations
{
    class OrderDetailsOperations
    {
        //4. Get the details for a specific order ID
        public static List<OrderDetail> GetOrderDetails(NorthwindContext db, int id)
        {
            List<OrderDetail> orderDetails = db.OrderDetails
                .Where(x => x.OrderId == id)
                .Include(o => o.Product).ToList();

            return orderDetails;
        }

        //5. Get the details for a specific product ID
        public static List<OrderDetail> GetProductDetails(NorthwindContext db, int id)
        {
            List<OrderDetail> oDetails = db.OrderDetails
                .Where(p => p.ProductId == id)
                .Include(oD => oD.Order).ToList();
            return oDetails;
        }
    }
}
