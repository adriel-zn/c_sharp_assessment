using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acccount_Ledger.Data.Models
{
    [Table("Account")]
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { set; get; }
        public string AccountName { set; get; }
        public double Amount { set; get; }
        [ForeignKey("AccountType")]
        public int AccountTypeId { set; get; }
        public virtual AccountType AccountType { set; get; }
    }
}
