using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public virtual List<OrderDetail> ListProducts { get; set; }
        public bool IsSubmited { get; set; }
        public virtual User User { get; set; }
        public Order()
        {
            ListProducts = new List<OrderDetail>();
        }
    }
}
