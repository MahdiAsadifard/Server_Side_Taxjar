using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Palitronica.Models
{
    public class CustomerDTO
    {
        public int id{ get; set; }
        public string name{ get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string zipCode { get; set; }

    }
}