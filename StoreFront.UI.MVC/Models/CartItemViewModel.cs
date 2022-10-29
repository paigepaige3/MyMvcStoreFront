using StoreFront.DATA.EF.Models;
using StoreFront.UI.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace StoreFront.UI.MVC.Models
{
    public class CartItemViewModel
    {
        public int Qty { get; set; }
        public Product CartProduct { get; set; }

        public CartItemViewModel() { }

        public CartItemViewModel(int qty, Product product)
        {
            Qty = qty;
            CartProduct = product;
        }
    }
}
