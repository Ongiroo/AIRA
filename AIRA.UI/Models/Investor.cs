using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AIRA.UI.Models
{
    public class Investor
    {
        public int ID { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime InvestmentDate { get; set; }

        public virtual ICollection<Investment> Investments { get; set; }
    }
}