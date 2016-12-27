using BB_DAL_EF.DBAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_DAL_EF
{
    public class BloodGroupValidation
    {
        DB_Blood_Group obj;
        public BloodGroupValidation()
        {
            obj = new DB_Blood_Group();
        }

        public bool InsertGroup(Blood_Group b_g)
        {
            return obj.Insert(b_g);
        }
    }
}
