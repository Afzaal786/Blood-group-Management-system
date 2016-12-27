using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_DAL_EF.DBAccessLayer
{ 
    public class DB_City
    {
        BBdataContext DBcity;
        public DB_City()
        {
            DBcity = new BBdataContext();
        }

        public bool Insert(City city)
        {
            DBcity.Cities.Add(city);
            return DBcity.SaveChanges()>0;
        }

    }
}
