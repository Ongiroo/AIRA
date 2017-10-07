using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string Description { get; set; }
        public int Shares { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasePrice { get; set; }
        public string Sign { get; set; }
        public double Commission { get; set; }
        public Currency CurrencyType { get; set; }
    }
}
