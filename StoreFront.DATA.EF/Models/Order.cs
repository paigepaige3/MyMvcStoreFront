using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Order
    {
        public Order()
        {
            ProductOrders = new HashSet<ProductOrder>();
        }

        public int OrderId { get; set; }
        public string? UserId { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual UserDetail? User { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
