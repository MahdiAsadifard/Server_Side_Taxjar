using Palitronica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Palitronica.Database
{
    public class StaticProducts : IDatabaseFactory<ProductDTO>
    {

        private List<ProductDTO> products = new List<ProductDTO>()
        {
             new ProductDTO()
                {
                    id = 1,
                    name = "Shoes",
                    price = 120
                },
                new ProductDTO()
                {
                    id = 2,
                    name = "Umbrella",
                    price = 200.20
                },
                new ProductDTO()
                {
                    id = 3,
                    name = "Pants",
                    price = 450.6
                },
                new ProductDTO()
                {
                    id = 4,
                    name = "Socks",
                    price = 10
                },
                new ProductDTO()
                {
                    id = 5,
                    name = "Shorts",
                    price = 25
                },
        };

        public List<ProductDTO> GetList()
        {
            return products;
        }
    }
}