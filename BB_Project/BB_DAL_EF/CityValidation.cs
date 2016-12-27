using BB_DAL_EF.DBAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_DAL_EF
{
    public class CityValidation
    {
        DB_City obj;
        public CityValidation()
        {
            obj = new DB_City();
        }

        public bool InsertCity(City city)
        {
            return obj.Insert(city);
        }
    }
}
