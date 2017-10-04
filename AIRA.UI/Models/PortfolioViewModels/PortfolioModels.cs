using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models.PortfolioViewModels
{
    public class PortfolioModels
    {
        public IEnumerable<Portfolio> Portfolios  { get; set; }
        public List<Industry> Sectors { get; set; }
    }
}
