using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5.GameFile
{
    public class GameUpdateCheckManager : IGameUpdateCheckService
    {
        public bool IsUpdateableGame(Game game)
        {
            return true;
        }
    }
}
