using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5.OfferFile
{
    public class OfferManager : IOfferService
    {
        public void AddOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " isimli kampanya eklendi");
        }

        public void DeleteOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " isimli kampanya silindi");
        }

        public void UpdateOffer(Offer offer)
        {
            Console.WriteLine(offer.OfferName + " isimli kampanya güncellendi");
        }
    }
}
