﻿using System;
using System.Collections.Generic;

namespace Roulette
{
    public class Table
    {
        public List<Player> players { get; private set; }
        public List<Bet> bets { get; private set; }
        Roulette roulette = new Roulette();

        private readonly IDictionary<int, string> numberSlots = new Dictionary<int, string>() {
            {0, "Green"},
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

        public void checkWinner()
        {

        }

        public Table(Player player)
        {
            players.Add(player);
        }
    }
}
