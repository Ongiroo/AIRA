﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models
{
    public class FixedIncome
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasePrice { get; set; }
        public double CurrentPrice { get; set; }
        public double Commission { get; set; }
        public Rating CreditQuality { get; set; }
        public DateTime MaturityDate { get; set; }
        public double Coupon { get; set; }
        public Currency CurrencyType { get; set; }
    }
}
