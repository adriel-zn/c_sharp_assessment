using Account_Ledger.Infrastruture.DTOs;
using Account_Ledger.Infrastruture.Services;
using Microsoft.AspNetCore.Mvc;

namespace Account_Ledger.Api.Controllers
{
    [ApiController]
    [Route("api/accounts")]
    public class AccountsController : ControllerBase
    {
        private IAccountsService _accountService;
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(IAccountsService service,ILogger<AccountsController> logger)
        {
            _logger = logger;
            _accountService = service;
        }

        #region HTTP GET
        [HttpGet("statements/{accountTypeId}")]
        public ActionResult GetAccountStatements(int accountTypeId)
        {
            try
            {
                return new OkObjectResult(_accountService.GetAccountStatements(accountTypeId));
            }
            catch (UnauthorizedAccessException)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            catch (InvalidOperationException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch
            {
                return new BadRequestObjectResult(new { Success = false, V = "An error has occurred" });
            }
        }
        #endregion HTTP GET

        #region HTTP POST
        [HttpPost]
        public ActionResult AddAccount(Account account)
        {
            try
            {

                return new OkObjectResult(_accountService.AddAccount(account.ConvertToModel()));
            }
            catch (UnauthorizedAccessException)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            catch (InvalidOperationException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch
            {
                return new BadRequestObjectResult(new { Success = false, V = "An error has occurred" });
            }
        }
        #endregion HTTP POST

        #region HTTP PUT
        [HttpPut("debit/{id}")]
        public ActionResult DebitAccount(Account account)
        {
            try
            {

                return new OkObjectResult(_accountService.DebitAccount(account.ConvertToModel()));
            }
            catch (UnauthorizedAccessException)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            catch (InvalidOperationException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch
            {
                return new BadRequestObjectResult(new { Success = false, V = "An error has occurred" });
            }
        }

        [HttpPut("credit/{id}")]
        public ActionResult CreditAccount(Account account)
        {
            try
            {

                return new OkObjectResult(_accountService.CreditAccount(account.ConvertToModel()));
            }
            catch (UnauthorizedAccessException)
            {
                return StatusCode(StatusCodes.Status403Forbidden);
            }
            catch (InvalidOperationException)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            catch
            {
                return new BadRequestObjectResult(new { Success = false, V = "An error has occurred" });
            }
        }
        #endregion HTTP PUT
    }
}