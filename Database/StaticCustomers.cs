using Palitronica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Palitronica.Database
{
    public class StaticCustomers : IDatabaseFactory<CustomerDTO>
    {
        private static List<CustomerDTO> customers = new List<CustomerDTO>()
        {
            new CustomerDTO()
            {
                id = 1,
                name = "Sender",
                country = "CA",
                state = "ON",
                city = "Toronto",
                street = "27 King's College Cir",
                zipCode = "M5S1A1"
            },
            new CustomerDTO()
            {
                id = 2,
                name = "DEFAULT_CUSTOMER",
                country = "CA",
                state = "ON",
                city = "Stratford",
                street = "393 ST Vincent S",
                zipCode = "N5A2Y5"
            },
            new CustomerDTO()
            {
                id = 3,
                name = "Mary",
                country = "CA",
                state = "ON",
                city = "Toronto",
                street = "317 Dundas St W",
                zipCode = "M5T1G4"
            },
            new CustomerDTO()
            {
                id = 4,
                name = "Smith",
                country = "CA",
                state = "BC",
                city = "Vancouver",
                street = "1455 Quebec St",
                zipCode = "V6A3Z7"
            },
            new CustomerDTO()
            {
                id = 5,
                name = "Jack",
                country = "CA",
                state = "AB",
                city = "Edmonton",
                street = "116 St & 85 Ave",
                zipCode = "T6G2R3"
            },
            new CustomerDTO()
            {
                id = 6,
                name = "John Doe",
                country = "CA",
                state = "SK",
                city = "Saskatoon",
                street = "2610 Lorne Ave",
                zipCode = "S7J0S6"
            },
            new CustomerDTO()
            {
                id = 7,
                name = "Louis",
                country = "CA",
                state = "QC",
                city = "Québec",
                street = "255 Ch Ste-Foy",
                zipCode = "G1R1T5"
            },
        };

        public List<CustomerDTO> GetList()
        {
            return customers;
        }
    }
}