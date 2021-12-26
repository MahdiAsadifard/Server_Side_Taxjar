using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Palitronica.Controllers;
using Palitronica.Models;
using Palitronica.Database;


namespace Palitronica.BL
{
    public class ProductOperations : BaseController
    {
        public static async Task<List<ProductDTO>> GetProducts()
        {
            StaticProducts products = new StaticProducts();

            return products.GetList();
        }

        public static async Task<ProductDTO> GetProductById(int id)
        {
            return GetProducts().Result.Where(x => x.id == id).FirstOrDefault();
        }
    }
}