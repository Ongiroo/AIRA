using System;
using System.Collections.Generic;
using System.Text;

namespace AIRA.Class
{
    public class BalanceSheet
    {
        public int AccountId { get; set; }
        public int AccountClassId { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal Amount { get; set; }
    }
}
