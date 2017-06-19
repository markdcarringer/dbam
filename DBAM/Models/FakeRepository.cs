using System.Collections.Generic;

namespace DBAM.Models
{
    public class FakeRepository : IAccountRepository
    {
        public IEnumerable<Account> Accounts => new List<Account>
        {
            new Account {Name = "Mark", EmpNumber = "123", Password = "Saic123$", Roles = new string[] { "SAIC_CREATE_SESSION_ROLE", "BI_REPORTING_ROLE"}, OrgSecurity = "B803"},
            new Account {Name = "Nick", EmpNumber = "234", Password = "Saic123$", Roles = new string[] { "SAIC_CREATE_SESSION_ROLE", "BI_REPORTING_ROLE"}, OrgSecurity = "GL"},
            new Account {Name = "Stan", EmpNumber = "345", Password = "Saic123$", Roles = new string[] { "SAIC_CREATE_SESSION_ROLE", "BI_REPORTING_ROLE"}, OrgSecurity = "GLEX"},
            new Account {Name = "Jay", EmpNumber = "456", Password = "Saic123$", Roles = new string[] { "SAIC_CREATE_SESSION_ROLE", "BI_REPORTING_ROLE"}, OrgSecurity = "GLEXST"}
        };
    }
}
