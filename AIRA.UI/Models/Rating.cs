using System.ComponentModel.DataAnnotations;

namespace AIRA.UI.Models
{
    public enum Rating
    {
        [Display(Name = "US Govt")]
        US_Govt,
        AAA,
        AA,
        A,
        BBB,
        BB,
        B,
        [Display(Name ="Below B")]
        BelowB,
        [Display(Name ="Not rated")]
        NotRated,
        Unknown
    }
}