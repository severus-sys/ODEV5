using ODEV5.GameFile;
using ODEV5.PlayerFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5.OfferFile
{
    public interface IGamesSalesService
    {
        void Sale(Player player,Offer offer,Game game);
    }
}
