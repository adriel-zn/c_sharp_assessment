using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acccount_Ledger.Data.Models
{
    [Table("AccountType")]
    public class AccountType
    {
        public int Id { get; set; }
        public string Name { set; get; }
    }
}
