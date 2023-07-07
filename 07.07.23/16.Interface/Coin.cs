using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface16
{
    /*
     * 创建一个名为Coin的抽象类
     */
    internal abstract class Coin
    {
        public abstract string? CoinName { get; protected set; }
        public abstract double CoinPrice { get; protected set; }
        public abstract int CoinTime { get; protected set; }

        public abstract void UpdateCoinPrice();
        public abstract void UpdateCoinTime();

    }

    internal class OKXCoin : Coin
    {
        public OKXCoin()
        {
            CoinName = "NULL";
            CoinPrice = 0.0;
            CoinTime = 0;
        }
        public OKXCoin(string name, double price, int time)
        {
            CoinName = name;
            CoinPrice = price;
            CoinTime = time;
        }

        override public string? CoinName { get; protected set; }
        public override double CoinPrice { get; protected set; }
        public override int CoinTime { get; protected set; }

        public override void UpdateCoinPrice()
        {
            // TODO
            throw new NotImplementedException();
        }
        public override void UpdateCoinTime()
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}
