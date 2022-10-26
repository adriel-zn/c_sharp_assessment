using System;
using System.Collections.Generic;
using System.Text;
using Acccount_Ledger.Data.Models;

namespace Account_Ledger.Infrastruture.DTOs
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { set; get; }
        public string AccountName { set; get; }
        public double Amount { set; get; }
        public AccountType AccountType { set; get; } = AccountType.None;

        public Acccount_Ledger.Data.Models.Account ConvertToModel()
        {
            return new Acccount_Ledger.Data.Models.Account
            {
                Id = Id,
                AccountNumber = this.AccountNumber,
                AccountName = this.AccountName,
                Amount = this.Amount
            };
        }

    }


    public enum AccountType
    {
        None = 0,
        Debit = 1,
        Credit = 2
    }
}
