using Account_Ledger.Infrastruture.DTOs;
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

        [HttpGet]
        public ActionResult GetAccountStatements(DateTime fromDate, DateTime toDate)
        {
            return new OkObjectResult(null);
        }

        [HttpPost]
        public ActionResult AddAccount(Account account)
        {
            return new OkObjectResult(null);
        }

        [HttpPut("debit/{id}")]
        public ActionResult DebitAccount(int id)
        {
            return new OkObjectResult(null);
        }

        [HttpPut("credit/{id}")]
        public ActionResult CreditAccount(int id)
        {
            return new OkObjectResult(null);
        }
    }
}