using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalCurrencyWallet.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
        public string PhoneNumber { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    public enum Country
    {
        Bangladesh
    }
}
