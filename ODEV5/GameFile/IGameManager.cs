using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5.GameFile
{
    public interface IGameManager
    {
        void AddGame(Game game);
        void RemoveGame(Game game);
        void UpdateGame(Game game);
    }
}
