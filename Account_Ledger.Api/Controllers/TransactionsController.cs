using Microsoft.AspNetCore.Mvc;

namespace Account_Ledger.Api.Controllers
{
    [ApiController]
    [Route("api/transactions")]
    public class TransactionsController : ControllerBase
    {
        private readonly ILogger<TransactionsController> _logger;

        public TransactionsController(ILogger<TransactionsController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet("statements")]
        public ActionResult AccountStatement(DateTime fromDate, DateTime toDate)
        {
            return new OkObjectResult(null);
        }

        [HttpPost]
        public ActionResult Transact(dynamic transaction)
        {
            return new OkObjectResult(null);
        }       

        [HttpDelete]
        public ActionResult Remove(int id)
        {
            return new OkObjectResult(null);
        }
    }
}