using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODEV5.PlayerFile
{
    public interface IPlayerManager
    {

        void Save(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
