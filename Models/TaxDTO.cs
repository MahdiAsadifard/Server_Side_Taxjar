using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Palitronica.Models
{
    public class TaxDTO
    {
        public string from_country { get; set; }
        public string from_zip { get; set; }
        public string from_state { get; set; }
        public string from_city { get; set; }
        public string to_country { get; set; }
        public string from_street { get; set; }
        public string to_zip { get; set; }
        public string to_state { get; set; }
        public string to_city { get; set; }
        public string to_street { get; set; }
        public double amount { get; set; }
        public double shipping { get; set; }
        public List<LineItemDTO> line_items { get; set; }

    }
}