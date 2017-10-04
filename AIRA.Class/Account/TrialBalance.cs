using System;
using System.Collections.Generic;
using System.Text;

namespace AIRA.Class
{
    public class TrialBalance
    {
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
    }
}
