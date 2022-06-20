using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AtoZBanking.Models
{
    public partial class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public DateTime TransactionDate { get; set; }
        [DataType(DataType.Currency)]
        public decimal AmountDebited { get; set; }
        public decimal FromAccountBalance { get; set; }
        public decimal ToAccountBalance { get; set; }


    }
}
