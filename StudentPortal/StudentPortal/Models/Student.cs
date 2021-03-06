//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentPortal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.Results = new HashSet<Result>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int DepartId { get; set; }
        public Nullable<int> Age { get; set; }
        public string BloodGroup { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<System.DateTime> DOA { get; set; }
        public string Addrs { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
