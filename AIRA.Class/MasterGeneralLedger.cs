using System;
using System.Collections.Generic;
using System.Text;

namespace AIRA.Class
{
    public partial class MasterGeneralLedger
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CurrencyId { get; set; }
        public string DocumentType { get; set; }
        public int TransactionNo { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public DateTime Date { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
