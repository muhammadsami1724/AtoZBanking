using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtoZBanking.Models
{
    public partial class Accounts
    {
        [Key]
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}
