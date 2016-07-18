﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZerodhaClientSharp.DomainTypes
{
    public class TradeData
    {
        public List<TradeDataRow> CandelsConverted {get;set; }
        public List<List<object>> candles { get; set; }

        public List<TradeDataRow> Convert()
        {
            List<TradeDataRow> convertedList = null;
            
            if(candles!=null && candles.Count > 0 )
            {
                Parallel.ForEach(candles,candle =>
                {
                    TradeDataRow row=new TradeDataRow();
                    Parallel.For(0,6, item =>{

                        if (item == 0)
                            row.TimeStamp = DateTime.Parse(candle[0].ToString());

                        if (item == 1)
                            row.Open = Double.Parse(candle[1].ToString());

                        if (item == 2)
                            row.High = Double.Parse(candle[2].ToString());

                        if (item == 3)
                            row.Low = Double.Parse(candle[3].ToString());

                        if (item == 4)
                            row.Close = Double.Parse(candle[4].ToString());

                        if (item == 5)
                            row.Volume = Double.Parse(candle[5].ToString());
                    });

                    convertedList.Add(row);                    
                });

            }
            CandelsConverted = convertedList;
            return convertedList;
        }
    }

    public class TradeDataRow
    {        
        public DateTime TimeStamp{get;set;}
        public double Open{get;set;}
        public double High{get;set;}
        public double Low{get;set;} 
        public double Close{get;set;}
        public double Volume{get;set;}


    }
}
