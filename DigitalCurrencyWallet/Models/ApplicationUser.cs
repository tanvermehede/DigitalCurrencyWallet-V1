using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalCurrencyWallet.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public ICollection<Profile> Profiles { get; set; }
        public ICollection<Finance> Finances { get; set; }

        public ApplicationUser()
        {
            Profiles = new Collection<Profile>();
            Finances = new Collection<Finance>();
        }
    }
}

