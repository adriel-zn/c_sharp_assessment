using Microsoft.AspNetCore.Mvc;

namespace Account_Ledger.Api.Controllers
{
    [ApiController]
    [Route("api/accounts")]
    public class AccountsController : ControllerBase
    {
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }   

        [HttpPost]
        public ActionResult AddAccount(dynamic account)
        {
            return new OkObjectResult(null);
        }

        [HttpPut]
        public ActionResult DebitAccount(dynamic account)
        {
            return new OkObjectResult(null);
        }

        [HttpPut]
        public ActionResult CreditAccount(dynamic account)
        {
            return new OkObjectResult(null);
        }
    }
}