using Acccount_Ledger.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Ledger.Infrastruture.Services
{
    public interface IAccountsService
    {
        public IList<Account> GetAccountStatements(DateTime fromDate, DateTime toDate);
        public Account AddAccount(Account account);
        public Account DebitAccount(Account account);
        public Account CreditAccount(Account account);
    }
}
