using System;
using System.Collections.Generic;
using System.Text;

namespace GameV2
{
    interface ISalesService
    {
        void Sell(Gamer gamer);
        void Sell(Gamer gamer, Campaign campaign);
    }
}
