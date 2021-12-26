using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Palitronica.Controllers;
using Palitronica.Models;
using Taxjar;
using Palitronica.Database;


namespace Palitronica.BL
{
    public class TaxOperations : BaseController
    {
        public static async Task<TaxResponseAttributes> CalculateTax(int id, TaxSubmissionDTO submission)
        {
            TaxjarApi client = Config();

            CustomerDTO customer = await CustomerOperations.GetCustomerById(id);
            CustomerDTO sender = await CustomerOperations.GetSender();


            return await client.TaxForOrderAsync(new TaxDTO
            {
                from_country = sender.country,
                from_zip = sender.zipCode,
                from_state = sender.state,
                from_city = sender.city,
                from_street = sender.street,
                to_country = customer.country,
                to_zip = customer.zipCode,
                to_state = customer.state,
                to_city = customer.city,
                to_street = customer.street,
                amount = submission.amount.HasValue ? submission.amount.Value : 0,
                shipping = submission.shipping.HasValue ? submission.shipping.Value : 0,
                line_items = submission.lineItems
            });
        }
    }
}