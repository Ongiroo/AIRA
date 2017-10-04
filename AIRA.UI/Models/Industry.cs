using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models
{
    public enum Industry
    {
        [Display(Name = "Basic Materials and Processing")]
        Basic_Materials_and_Processing,
        [Display(Name = "Consumer Discretionary")]
        Consumer_Discretionary,
        [Display(Name = "Consumer Staples")]
        Consumer_Staples,
        [Display(Name = "Energy")]
        Energy,
        [Display(Name = "Financial Services")]
        Financial_Services,
        [Display(Name = "Health Care")]
        Health_Care,
        [Display(Name = "Industrial Producer Durable")]
        Industrial_Producer_Durables,
        [Display(Name = "Technology")]
        Technology,
        [Display(Name = "Telecommunications")]
        Telecommunications,
        [Display(Name = "Utilities")]
        Utilities
    }
}
