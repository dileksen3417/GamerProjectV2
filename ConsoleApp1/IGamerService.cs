using System;
using System.Collections.Generic;
using System.Text;

namespace GameV2
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
