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
    public class CustomerOperations : BaseController
    {
         static  StaticCustomers customers = new StaticCustomers();
        public static async Task<List<CustomerDTO>> GetCustomers()
        {
            return customers.GetList().Where(x => x.id > 2).ToList();
        }

        public static async Task<CustomerDTO> GetCustomerById(int id)
        {
            return customers.GetList().Where(x => x.id == id).FirstOrDefault();
        }

        public static async Task<CustomerDTO> GetSender()
        {
            return customers.GetList().Where(x => x.id == 1).FirstOrDefault();
        }
    }
}