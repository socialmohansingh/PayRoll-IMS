//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMSApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MODE
    {
        public MODE()
        {
            this.EMP_TRAN = new HashSet<EMP_TRAN>();
        }
    
        public short MODE_ID { get; set; }
        public string MODE_NAME { get; set; }
        public string MODE_ABB { get; set; }
    
        public virtual ICollection<EMP_TRAN> EMP_TRAN { get; set; }
    }
}