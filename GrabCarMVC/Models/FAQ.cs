//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrabCarMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FAQ
    {
        public int FAQId { get; set; }
        public Nullable<int> Flag { get; set; }
        public string FAQQuestion { get; set; }
        public string FAQAnswer { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    }
}
