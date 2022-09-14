using System;
using System.Collections.Generic;

namespace CaseStudySolution2._0.Models.DB
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string OfficeAddress { get; set; } = null!;
        public string PhoneExtension { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;

        public virtual Person EmployeeNavigation { get; set; } = null!;
    }
}
