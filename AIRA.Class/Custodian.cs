using System;
using System.Collections.Generic;
using System.Text;

namespace AIRA.Class
{
    public class Custodian : Employee
    {
        #region constructors 
        public Custodian() { }

        // As a general rule, all subclasses should explicitly call an appropriate
        // base class constructor.
        public Custodian(string fullName, int age, int empID,
          float currPay, string ssn, int numbOfSales)
          : base(fullName, age, empID, currPay, ssn)
        {
            // This belongs with us!
            DealNumber = numbOfSales;
        }
        #endregion

        public int DealNumber { get; set; }

        // A salesperson's bonus is influenced by the number of sales.
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (DealNumber >= 0 && DealNumber <= 100)
                salesBonus = 10;
            else
            {
                if (DealNumber >= 101 && DealNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of deals: {0}", DealNumber);
        }
    }
}
