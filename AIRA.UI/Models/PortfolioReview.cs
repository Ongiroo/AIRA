using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AIRA.UI.Models
{
    public class PortfolioReview : IValidatableObject
    {
        public int Id { get; set; }
        [Required]
        [Range(1, 10)]
        public int Rating { get; set; }
        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        [Display(Name = "User Name")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string ReviewName { get; set; }
        public int PortfolioId { get; set; }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (Rating < 2 && ReviewName.ToLower().StartsWith("amgalan"))
            {
                yield return new ValidationResult("Sorry, Amgalan, you cannot do this!");

            }
        }
    }
}