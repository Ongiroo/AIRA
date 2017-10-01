using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models
{
    public class Equity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EquityID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Investment> Investments { get; set; }
    }
}
