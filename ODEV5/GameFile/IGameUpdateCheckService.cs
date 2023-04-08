using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5.GameFile
{
    public interface IGameUpdateCheckService
    {
        bool IsUpdateableGame(Game game);
        
    }
}
