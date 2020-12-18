using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_LTWEB.Models
{
    public class PlacesModel
    {
        DataHVtravelDataContext db = new DataHVtravelDataContext();

        public object findAllPlace()
        {
            var data = from u in db.PLACEs
                       select u;
            return data;
        }
    }
}