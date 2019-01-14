using System;
using System.Collections.Generic;

namespace Roulette
{
    public class Bet
    {
        public enum MoneyBid
        {
            USD_1 = 1,
            USD_5 = 5,
            USD_25 = 25,
            USD_50 = 50,
            USD_100 = 100
        }

        public enum BetType
        {
            numeric,
            color,
            parity,
            range
        }

        public enum Color
        {
            Black,
            Red
        }

        public enum Parity
        {
            even,
            odd
        }

        public enum Range
        {
            FirstTwelve,
            SecondTwelve,
            ThirdTwelve,
            FirstEighteen,
            SecondEighteen
        }

        //private readonly IDictionary<int, string> numberSlots = new Dictionary<int, string>(36) {
        //    {0, "Green"},
        //    {1, "Red"},
        //    {2, "Black"},
        //    {3, "Red"},
        //    {4, "Black"},
        //    {5, "Red"},
        //    {6, "Black"},
        //    {7, "Red"},
        //    {8, "Black"},
        //    {9, "Red"},
        //    {10, "Black"},
        //    {11, "Black"},
        //    {12, "Red"},
        //    {13, "Black"},
        //    {14, "Red"},
        //    {15, "Black"},
        //    {16, "Red"},
        //    {17, "Black"},
        //    {18, "Red"},
        //    {19, "Red"},
        //    {20, "Black"},
        //    {21, "Red"},
        //    {23, "Red"},
        //    {24, "Black"},
        //    {25, "Red"},
        //    {26, "Black"},
        //    {27, "Red"},
        //    {28, "Black"},
        //    {29, "Black"},
        //    {30, "Red"},
        //    {31, "Black"},
        //    {32, "Red"},
        //    {33, "Black"},
        //    {34, "Red"},
        //    {35, "Black"},
        //    {36, "Red"}
        //};

        public BetType type { get; private set; }

        public int moneyBid { get; private set; }

        public int slot { get; private set; }

        public string color { get; private set; }

        public string parity { get; private set; }

        public int[] range { get; private set; }


        // SETTER FOR NUMERIC BET TYPE
        public void SetValues(MoneyBid moneyBid, int slot)
        {
            type = BetType.numeric;
            this.moneyBid = (int)moneyBid;
            this.slot = slot;
            // color = numberSlots[slot];
        }

        // SETTER FOR COLOR BET TYPE
        public void SetValues(MoneyBid moneyBid, Color color)
        {
            type = BetType.color;
            this.moneyBid = (int)moneyBid;
            this.color = color.ToString();
        }

        // SETTER FOR PARITY BET TYPE
        public void SetValues(MoneyBid moneyBid, Parity parity)
        {
            type = BetType.parity;
            this.moneyBid = (int)moneyBid;
            this.parity = parity.ToString();
        }

        // SETTER FOR RANGE BET TYPE
        public void SetValues(MoneyBid moneyBid, Range range)
        {
            type = BetType.range;
            this.moneyBid = (int)moneyBid;
            switch (range)
            {
                case Range.FirstEighteen:
                    this.range = new int[]{ 1,2,3,4,5,6,7,8,9,10,11,12 };
                    break;
                case Range.SecondTwelve:
                    this.range = new int[]{ 13,14,15,16,17,18,19,20,21,22,23,24 };
                    break;
                case Range.ThirdTwelve:
                    this.range = new int[]{ 25,26,27,28,29,30,31,32,33,34,35,36 };
                    break;
                default:
                    break;
            }
        }

    }
}
