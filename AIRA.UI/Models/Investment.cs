namespace AIRA.UI.Models
{
    public class Investment
    {
        public int InvestmentID { get; set; }
        public int EquityID { get; set; }
        public int FixedIncomeID { get; set; }
        public int CommodityID { get; set; }
        public int InvestorID { get; set; }
        public Performance? Performance { get; set; }

        public virtual Equity Equity { get; set; }
        public virtual Investor Investor { get; set; }

        public decimal Price { get; set; }
    }
}