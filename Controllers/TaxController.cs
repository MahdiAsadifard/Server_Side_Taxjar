using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Taxjar;
using System.Web.Http;
using Palitronica.BL;
using System.Threading.Tasks;
//using RouteAttribute = System.Web.Http.RouteAttribute;
//using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
//using HttpPutAttribute = System.Web.Http.HttpPutAttribute;
//using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using System.Web.Http.Cors;
using Palitronica.Models;
using System.Net;

namespace Palitronica.Controllers
{
    [EnableCors("*", "*", "*")]
    public class TaxController : ApiController
    {
        [Route("~/api/tax/{id}")]
        [HttpPut]
        public async Task<TaxResponseAttributes> CalculateTax(int id, [FromBody] TaxSubmissionDTO submission)
        {
            return await TaxOperations.CalculateTax(id, submission);
        }

        [Route("~/api/products")]
        [HttpGet]
        public async Task<List<ProductDTO>> GetProducts()
        {
            return await ProductOperations.GetProducts();
        }

        [Route("~/api/customers")]
        [HttpGet]
        public async Task<List<CustomerDTO>> GetUsers()
        {
            return await CustomerOperations.GetCustomers();
        }
    }
}