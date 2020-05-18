using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Entities {
    class GridGame {
        public char[] Grid { get; private set; } = new char[9];

        public void InitiateGrid() {
            for (int i = 0; i < 9; i++) {
                Grid[i] = '-';
            }
        }
        public override string ToString() {
            return "\n " + Grid[0] + " | " + Grid[1] + " | " + Grid[2] + " " +
                   "\n-----------" +
                   "\n " + Grid[3] + " | " + Grid[4] + " | " + Grid[5] + " " +
                   "\n-----------" +
                   "\n " + Grid[6] + " | " + Grid[7] + " | " + Grid[8] + " ";
        }
    }
}
