using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models.PortfolioViewModels
{
    public class PortfolioListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReturnAttribution { get; set; }
        public string RiskAttribution { get; set; }
        public int CountOfReviews { get; set; }
    }
}
