using System;

namespace DBAM.Models
{
    public class Account
    {
        public string Name { get; set; }
        public string EmpNumber { get; set; }
        public string Password { get; set; }
        public string[] Roles { get; set; }
        public string OrgSecurity { get; set; }
    }
}
