using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models.PortfolioViewModels
{
    public class ReviewEditViewModel
    {
        public int Id { get; set; }
        public int PortfolioId { get; set; }
        public string Benchmark { get; set; }
        public string Rating { get; set; }
    }
}
