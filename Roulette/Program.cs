using System;

namespace Roulette
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declare and initialize bet object somewhere global
            Bet userBet = new Bet(;

            // Call method set bet values when user presses Spin
            Console.WriteLine(userBet.moneyBid);
            Console.WriteLine(userBet.color);
            Console.WriteLine(userBet.type);
        }
    }
}
