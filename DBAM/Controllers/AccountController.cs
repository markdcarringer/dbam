using Microsoft.AspNetCore.Mvc;
using DBAM.Models;

namespace DBAM.Controllers
{
    public class AccountController : Controller
    {
        private IAccountRepository repository; 
   
        public AccountController(IAccountRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Accounts);
    }
}
