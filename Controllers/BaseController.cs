using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Configuration;
using System.Collections.Specialized;
using Taxjar;

namespace Palitronica.Controllers
{
    public class BaseController : ApiController
    {
        public static TaxjarApi Config()
        {
            return new TaxjarApi(ConfigurationManager.AppSettings["TaxjarApiKey"]);
        }
    }
}