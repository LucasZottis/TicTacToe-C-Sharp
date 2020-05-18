using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Entities {
    class IAManager {
        public string Name { get; private set; }
        public char PlayerMove { get; private set; }
        public int Matches { get; private set; }
        public int Wins { get; private set; }
        public int Ties { get; private set; }
        public int Loses { get; private set; }

        public IAManager() {
            Name = "Cidão";
            PlayerMove = 'O';
        }
        public char Move(GridGame game) {
            Random randomSpot = new Random();
            int spot = randomSpot.Next(0, 9);
            if (game.Grid[spot] == '-') {
                game.Grid[spot] = PlayerMove;
                return GameManager.Oppositve(PlayerMove);
            } else {
                Console.WriteLine("Pensando!!");
                return PlayerMove;
            }
        } 
    }
}
