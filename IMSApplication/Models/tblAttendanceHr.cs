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
    
    public partial class tblAttendanceHr
    {
        public int Emp_ID { get; set; }
        public System.DateTime TDate { get; set; }
        public decimal Mins { get; set; }
        public string Remarks { get; set; }
        public string EnteredBy { get; set; }
        public byte Flg { get; set; }
    }
}