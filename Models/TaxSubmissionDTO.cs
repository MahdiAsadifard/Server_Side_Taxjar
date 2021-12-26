using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Palitronica.Models
{
    public class TaxSubmissionDTO
    {
        //public CustomerDTO customer { get; set; }
        public List<LineItemDTO> lineItems { get; set; }
        public ProductDTO product { get; set; }
        public double? amount { get; set; }
        public double? shipping { get; set; }
    }
}