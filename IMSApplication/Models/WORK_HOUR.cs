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
    
    public partial class WORK_HOUR
    {
        public WORK_HOUR()
        {
            this.DEFAULT_WORKHOUR = new HashSet<DEFAULT_WORKHOUR>();
            this.ATTENDANCEs = new HashSet<ATTENDANCE>();
        }
    
        public short WORK_ID { get; set; }
        public string WORK_HOUR1 { get; set; }
        public string IN_START { get; set; }
        public string IN_END { get; set; }
        public string OUT_START { get; set; }
        public string OUT_END { get; set; }
        public Nullable<short> LUNCHTIME { get; set; }
        public Nullable<short> TIFFINTIME { get; set; }
        public Nullable<bool> IS_NIGHTSHIFT { get; set; }
    
        public virtual ICollection<DEFAULT_WORKHOUR> DEFAULT_WORKHOUR { get; set; }
        public virtual ICollection<ATTENDANCE> ATTENDANCEs { get; set; }
    }
}
