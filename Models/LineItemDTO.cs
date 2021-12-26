using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Palitronica.Models
{
    public class LineItemDTO
    {
        public string id { get; set; }
        public double quantity { get; set; } = 0;
        public string product_tax_code { get; set; }
        public double unit_price { get; set; } = 0;
        public double discount { get; set; } = 0;
    }
}