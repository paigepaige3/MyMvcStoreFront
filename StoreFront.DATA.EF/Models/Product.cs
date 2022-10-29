using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductOrders = new HashSet<ProductOrder>();
            ProductStatuses = new HashSet<ProductStatus>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public int? CategoryId { get; set; }
        public decimal? Price { get; set; }
        public short? QtyInStock { get; set; }
        public decimal? DiscountPrice { get; set; }
        public int? SupplierId { get; set; }
        public bool? Discontinued { get; set; }
        public string? ProductImage { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
        public virtual ICollection<ProductStatus> ProductStatuses { get; set; }
    }
}
