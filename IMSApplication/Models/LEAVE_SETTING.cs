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
    
    public partial class LEAVE_SETTING
    {
        public short MIN_DAYS { get; set; }
        public short HLF_DAYS { get; set; }
        public Nullable<System.DateTime> DAYCOUNT_START { get; set; }
        public byte DAYCOUNT_MODE { get; set; }
        public byte ALLOW_UNPAIDLEAVE_YEARLY { get; set; }
        public short PREANNUALEXPIRY { get; set; }
        public byte MUSTPRESENT_FOR_HALFDAY { get; set; }
        public byte HOURLYLEAVE { get; set; }
        public Nullable<decimal> LEAVEHOURS_PERDAY { get; set; }
        public short LEAVEROUNDNUMBER { get; set; }
        public byte TMPLEAVE { get; set; }
        public byte DEFINE_LEAVEPAYQTY { get; set; }
        public byte LEAVEONWH { get; set; }
    }
}
