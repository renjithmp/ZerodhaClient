using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZerodhaClientSharp.WebSocket
{

    class WebSocketEngine
    {
        public  delegate void  GetFullTickWithMarketDepth(List<FullTick> ticks);
        public delegate void GetTick(Tick tick,int instrument_Id);
        public event GetFullTickWithMarketDepth GetTradeDataWithDetails;
        public event GetFullTickWithMarketDepth GetTradeData;
        public event GetTick GetTickForAnInstrument;

        public void Run(bool run)
        {
            while(run)
            {



            }


        }
    }
}
