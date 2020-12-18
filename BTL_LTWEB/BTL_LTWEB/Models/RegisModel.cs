using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_LTWEB.Models
{
    public class RegisModel
    {
        DataHVtravelDataContext db = new DataHVtravelDataContext();
       public object findAllRegis()
        {
            var data = from u in db.Registrations
                       select u;                     
            return data;
        }
    }
}