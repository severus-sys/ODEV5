using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5.PlayerFile
{
    public class PlayerManager : IPlayerManager
    {
        IPlayerCheckService _checkService;

        public PlayerManager(IPlayerCheckService checkService)
        {
            this._checkService = checkService;
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Hesap Siliniyor ----> " + player.Id + "-" + player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Hesap Güncellendi" + player.Id + "-" + player.FirstName);
        }

        public void Save(Player player)
        {
            if(_checkService.CheckRealPerson(player))
            {
                Console.WriteLine("Hesap Kaydedildi");

            }
            else
            {
                Console.WriteLine("Kimlik Bilgileriniz Yanlış...");
            }
        }
    }
}
