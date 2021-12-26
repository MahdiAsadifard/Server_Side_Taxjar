using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Palitronica.Database
{
    public interface IDatabaseFactory<T>
    {
         List<T> GetList();
    }
}