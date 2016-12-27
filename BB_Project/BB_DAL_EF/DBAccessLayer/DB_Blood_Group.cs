using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_DAL_EF.DBAccessLayer
{
   public class DB_Blood_Group
    {
       BBdataContext Bld_Grp;
       public DB_Blood_Group()
       {
           Bld_Grp = new BBdataContext();
       }
       public bool Insert(Blood_Group b_g)
       {
           Bld_Grp.Blood_Group.Add(b_g);
           return Bld_Grp.SaveChanges() > 0;
       }

    }
}
