using System;
using System.Collections.Generic;

namespace Roulette
{
    public class Bet
    {
        private readonly IDictionary<int, string> numberSlots = new Dictionary<int, string>(36) {
            {1, "Red"},
            {2, "Black"},
            {3, "Red"},
            {4, "Black"},
            {5, "Red"},
            {6, "Black"},
            {7, "Red"},
            {8, "Black"},
            {9, "Red"},
            {10, "Black"},
            {11, "Black"},
            {12, "Red"},
            {13, "Black"},
            {14, "Red"},
            {15, "Black"},
            {16, "Red"},
            {17, "Black"},
            {18, "Red"},
            {19, "Red"},
            {20, "Black"},
            {21, "Red"},
            {23, "Red"},
            {24, "Black"},
            {25, "Red"},
            {26, "Black"},
            {27, "Red"},
            {28, "Black"},
            {29, "Black"},
            {30, "Red"},
            {31, "Black"},
            {32, "Red"},
            {33, "Black"},
            {34, "Red"},
            {35, "Black"},
            {36, "Red"}
        };

        public int betMoneyAmount { get; private set; }

        public int slot { get; private set; }

        public string color { get; private set; }

        public void SetValues(int betMoneyAmount, int slot)
        {
            this.betMoneyAmount = betMoneyAmount;
            this.slot = slot;
            color = numberSlots[slot];
        }
    }
}
