//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapi.millerdcjr.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        public int Id { get; set; }
        public System.Guid UserId { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public System.DateTime JobStartDate { get; set; }
        public Nullable<System.DateTime> JobEndDate { get; set; }
    }
}
