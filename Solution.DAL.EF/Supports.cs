//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solution.DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supports
    {
        public int SupportId { get; set; }
        public int GoalId { get; set; }
        public string UserId { get; set; }
        public System.DateTime SupportedDate { get; set; }
    }
}
