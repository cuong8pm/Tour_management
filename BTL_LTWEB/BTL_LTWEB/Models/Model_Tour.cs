using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_LTWEB.Models
{
    public class Model_Tour : DBConnection
    {
        public object getAllData()
        {
            var data = from tour in db.TOURs
                       select tour;
            return data;
        }
        public TOUR getDataById(int id)
        {
            TOUR data = db.TOURs.First(t => t.ID == id);
            return data;
        }
        public void update(TOUR t)
        {
            TOUR t2 = db.TOURs.SingleOrDefault(t3 => t3.ID == t.ID);
            t2.Title = t.Title;
            db.SubmitChanges(); 
        }
    }
}