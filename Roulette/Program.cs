using System;

namespace Roulette
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declare and initialize bet object somewhere global
            Bet userBet = new Bet();

            // Call method set bet values when user presses Spin
            userBet.SetValues(betMoneyAmount: 5, slot: 8);
        }
    }
}
