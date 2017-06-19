using System.Collections.Generic;

namespace DBAM.Models
{
    public interface IAccountRepository
    {
        IEnumerable<Account> Accounts { get; }
    }
}
