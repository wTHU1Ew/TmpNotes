namespace Interface16
{
    class Program
    {
        static void Main(string[] args)
        {
            OKXPosition p1 = new();
            OKXPosition p2 = new OKXPosition("aaa", 1, 2, 3, 4);
            LogInfo li=p1 as LogInfo;
            li.LogAll();
            OKXPosition[] op=new OKXPosition[10];
            Random rd = new Random();
            for(int i = 0; i < 10; i++)
            {
                op[i]=new OKXPosition("aaa"+i, 1+rd.Next(), 2, 3, 4);
            }
            Array.Sort(op);
            for(int i = 0; i < 10; i++)

            {
                Console.WriteLine("CoinName: {0}\nCoinPrice: {1}\n", op[i].CoinName, op[i].CoinPrice);
            }
        }
    }
}  
