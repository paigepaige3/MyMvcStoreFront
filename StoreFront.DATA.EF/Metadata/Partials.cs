using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFront.DATA.EF.Metadata
{
    [ModelMetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {

    }


    [ModelMetadataType(typeof(ProductMetadata))]
    public partial class Product
    {

    }

    
    [ModelMetadataType(typeof(ProductStatusMetada))]
    public partial class ProductStatus
    {

    }
}
