using Interface16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface16
{
    internal interface LogInfo
    {
        void LogAll();
    }
    internal interface LogInfo2
    {
        void LogAll();
    }
    internal class OKXPosition: OKXCoin, IComparable, LogInfo, LogInfo2
    {
        public double StartPrice { get; protected set; }
        public double RateofReturn { get; protected set; }

        public OKXPosition()
        {
            ((LogInfo)this).LogAll();
            ((LogInfo2)this).LogAll();
        }
        public OKXPosition(string name, double price, int time, double startprice, double rateofreturn)
        {
            CoinName = name;
            CoinPrice = price;
            CoinTime = time;
            StartPrice = startprice;
            RateofReturn = rateofreturn;
            ((LogInfo)this).LogAll();
            ((LogInfo2)this).LogAll();
        }
        public int CompareTo(object? obj)
        {
            if (obj != null)
            {
                OKXPosition p = (OKXPosition)obj;
                if (this.CoinPrice > p.CoinPrice)
                {
                    return 1;
                }
                else if (this.CoinPrice < p.CoinPrice)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException("obj is null!\n");
            }
        }
        void LogInfo.LogAll()
        {
            Console.WriteLine("CoinName: {0}\nCoinPrice: {1}\nCoinTime: {2}\nStartPrice: {3}\nRateofReturn: {4}\n", CoinName, CoinPrice, CoinTime, StartPrice, RateofReturn);
        }
        void LogInfo2.LogAll()
        {             
            Console.WriteLine("Log2: CoinName: {0}\nCoinPrice: {1}\nCoinTime: {2}\nStartPrice: {3}\nRateofReturn: {4}\n", CoinName, CoinPrice, CoinTime, StartPrice, RateofReturn);
        }

    }
}
