using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models
{
    public class Cash
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalAmount { get; set; }
        public DateTime Date { get; set; }
        public Currency CurrencyType { get; set; }
    }
}
