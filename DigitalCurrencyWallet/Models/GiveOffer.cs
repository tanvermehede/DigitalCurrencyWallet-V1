using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalCurrencyWallet.Models
{
    public class GiveOffer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int EnterAmount { get; set; }
        public int AmountPrice { get; set; }
        public int OfferPrice { get; set; }
    }
}
