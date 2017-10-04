using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReturnAttribution { get; set; }
        public string RiskAttribution { get; set; }
        public virtual ICollection<PortfolioReview> Reviews { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [EnumDataType(typeof(Industry))]
        public Industry Sector { get; set; }
    }
}
