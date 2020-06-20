using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalCurrencyWallet.Models
{
    public class Finance
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public double CurrencyRate { get; set; }
        public double MyBalance { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
