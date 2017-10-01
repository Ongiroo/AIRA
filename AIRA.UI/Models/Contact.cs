using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIRA.UI.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public List<Product> Why { get; set; }
        public JobTitle? JobTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrganisationName { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        public string City { get; set; }
        public string StateZip { get; set; }
        public string Country { get; set; }
        public string HowHearUs { get; set; }
        public string Comments { get; set; }
    }
}
