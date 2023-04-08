using ODEV5.GameFile;
using ODEV5.PlayerFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5.OfferFile
{
    public class OfferGameManager : IGamesSalesService
    {
        public void Sale(Player player, Offer offer, Game game)
        {
            float price = game.Price - ((game.Price * offer.DiscountRate) / 100); 
            Console.WriteLine(game.GameName + " isimli oyun " + player.Id + " si olan oyuncuya satılmıştır. ");
        }
    }
}
