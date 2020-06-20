using DigitalCurrencyWallet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalCurrencyWallet.Databases
{
    public class MyDbContext : IdentityDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<Finance> Finance { get; set; }
        public DbSet<GiveOffer> GiveOffer { get; set; }

    }
}
