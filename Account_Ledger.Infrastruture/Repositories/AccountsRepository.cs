using Acccount_Ledger.Data.Models;
using Account_Ledger.Data;
using Account_Ledger.Infrastruture.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Ledger.Infrastruture.Repository
{
    public class AccountsRepository : IAccountsService
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<Account> _account;


        public AccountsRepository(DatabaseContext _context)
        {
            this._context = _context;
        }

        public IList<Account> GetAccountStatements(DateTime fromDate, DateTime toDate)
        {
            return null;
        }

        public Account AddAccount(Account account)
        {
            _account.Add(account);
            _context.SaveChanges();
            return account;
        }

        public Account DebitAccount(Account account)
        {

            if (account == null)
                throw new ArgumentNullException("Account Invalid");

            _context.SaveChanges();

            return account;
        }

        public Account CreditAccount(Account account)
        {
            if (account == null)
                throw new ArgumentNullException("Account Invalid");
            _context.SaveChanges();

            return account;
        }

        public Account RemoveAccount(Account account)
        {
            if (account == null)
                throw new ArgumentNullException("AccountId is Invalid");
            
            _account.Remove(account);
            _context.SaveChanges();

            return account;
        }
    }
}
