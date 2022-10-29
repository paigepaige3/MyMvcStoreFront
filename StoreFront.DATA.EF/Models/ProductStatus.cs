using System;
using System.Collections.Generic;

namespace StoreFront.DATA.EF.Models
{
    public partial class ProductStatus
    {
        public int ProductStatusId { get; set; }
        public int? ProductId { get; set; }
        public bool InStock { get; set; }
        public bool OnBackOrder { get; set; }
        public bool? Discontinued { get; set; }

        public virtual Product? Product { get; set; }
    }
}
