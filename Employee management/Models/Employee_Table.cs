//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee_Table
    {
        public int EmployeeUID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Department { get; set; }
        public string designation { get; set; }
        public System.DateTime DateOfJoining { get; set; }
        public int Salary { get; set; }
        public int OfficeHours { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string ContactInfo { get; set; }
        public string Supervisor { get; set; }
    }
}
