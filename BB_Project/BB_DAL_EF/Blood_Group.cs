//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BB_DAL_EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blood_Group
    {
        public Blood_Group()
        {
            this.Donors = new HashSet<Donor>();
            this.Receivers = new HashSet<Receiver>();
        }
    
        public int B_Id { get; set; }
        public string Group_Name { get; set; }
    
        public virtual ICollection<Donor> Donors { get; set; }
        public virtual ICollection<Receiver> Receivers { get; set; }
    }
}