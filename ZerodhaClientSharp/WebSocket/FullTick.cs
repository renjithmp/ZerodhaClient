using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZerodhaClientSharp.WebSocket
{
    //    0 - 4	int32	instrument_token
    //4 - 8	   int32	Last traded price (If mode is ltp, the packet ends here)
    //8 - 12	int32	Last traded quantity
    //12 - 16	int32	Average traded price
    //16 - 20	int32	Volume traded for the day
    //20 - 24	int32	Total buy quantity
    //24 - 28	int32	Total sell quantity
    //28 - 32	int32	Open price
    //32 - 36	int32	High price
    //36 - 40	int32	Low price
    //40 - 44	int32	Close price (If mode is quote, the packet ends here)
    //44 - 164	[]byte	Market depth entries
    public class FullTick
    {
        public int instrument_token;
        public int  instrument_token;
        public int  Last_traded_price;// (If mode is ltp, the packet ends here)
        public int  Last_traded_quantity;
        public int  Average_traded_price;
        public int  Volume_traded;// for the day
        public int Total_buy_quantity;
        public int  Total_sell_quantity;
        public int  Open_price;
        public int  High_price;
        public int  Low_price;
        public int  Close_price;// (If mode is quote, the packet ends here)
        public MarketDepth[]  Market_depth_entries;    
    }
}
