using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Ledger.Infrastruture.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string AccountNumber { set; get; }
        public string AccountName { set; get; }
        public double Amount { set; get; }
        public AccountType AccountType { set; get; } = AccountType.None;

    }


    public enum AccountType
    {
        None = 0,
        Debit = 1,
        Credit = 2
    }
}
