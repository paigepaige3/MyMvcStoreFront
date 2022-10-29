using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF.Metadata
{


    public class CategoryMetaData
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "*Category is required")]
        [StringLength(50, ErrorMessage = "*Must be 50 charecters or less")]
        [Display(Name = "Category")]
        public string? CategoryName { get; set; }
    }
    public class ProductMetadata
    {
        public int ProductId { get; set; }

        [StringLength(50, ErrorMessage = "*Cannot exceed 50 charecters")]
        [Required(ErrorMessage = "*Product Name is required")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; } = null!;

        [StringLength(200, ErrorMessage = "*Cannot exceed 200 charecters")]
        [Display(Name = "Description")]
        public string? ProductDescription { get; set; }

        public int? CategoryId { get; set; }

        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false)]
        [Range(0, (double)decimal.MaxValue)]
        public decimal? Price { get; set; }

        [Display(Name = "Amount In Stock")]
        [Range(0, short.MaxValue)]
        public short? QtyInStock { get; set; }

        [Display(Name = "Discount Price")]
        [DisplayFormat(DataFormatString = "{0:c}", ApplyFormatInEditMode = false)]
        [Range(0, (double)decimal.MaxValue)]
        public decimal? DiscountPrice { get; set; }

        public int? SupplierId { get; set; }

        [Display(Name = "Discontinued?")]
        public bool? Discontinued { get; set; }

        [StringLength(75, ErrorMessage = "*Cannot exceed 75 charecters")]
        [Display(Name = "Image")]
        public string? ProductImage { get; set; }
    }

    public class ProductStatusMetada
    {
        public int ProductStatusId { get; set; }
        public int? ProductId { get; set; }

        [Display(Name = "Amount In Stock")]
        [Range(0, short.MaxValue)]
        public bool InStock { get; set; }

        [Display(Name = "Amount On Backorder")]
        [Range(0, short.MaxValue)]
        public bool OnBackOrder { get; set; }

        [Display(Name = "Discontinued?")]
        public bool? Discontinued { get; set; }
    }
}
