using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCRetailerWeb.Models.ProductsViewModels
{
    public class ProductsViewModels
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string MRP { get; set; }
        public string SP { get; set; }
        public string OfferDescription { get; set; }
        public bool IsOnOffer { get; set; }

        public byte[] ProductImage { get; set; }
    }
}
