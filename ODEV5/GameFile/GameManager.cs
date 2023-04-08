using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5.GameFile
{
    public class GameManager : IGameManager
    {
        IGameUpdateCheckService _updateCheckService;

        public GameManager(IGameUpdateCheckService gameUpdateCheckService)
        {
            this._updateCheckService = gameUpdateCheckService;
        }

        public void AddGame(Game game)
        {
            Console.WriteLine(game.GameName + " oyunlu isim sisteme yüklenmiştir.");
        }

        public void UpdateGame(Game game)
        {
            if (_updateCheckService.IsUpdateableGame(game))
            {
                Console.WriteLine(game.Id + " li " + game.GameName + " isimli oyun güncellenmiştir.");
            }

        }

        public void RemoveGame(Game game)
        {
            Console.WriteLine(game.GameName + " oyun silinmiştir.");
        }
    }
}
