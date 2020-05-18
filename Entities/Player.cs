using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Entities {
    class Player {
        public string Name { get; private set; }
        public char PlayerMove { get; private set; }
        public int Matches { get; private set; }
        public int Wins { get; private set; }
        public int Ties { get; private set; }
        public int Loses { get; private set; }

        public Player(char playerMove) {
            PlayerMove = playerMove;
        }
        public bool SetName() {
            Console.Write($"Nome player \"{PlayerMove}\": ");
            string name = Console.ReadLine();
            if (name != null && name.Length > 1) {
                Name = name;
                return false;
            } else {
                return true;
            }
        }
        public char Move(GridGame grid) {
            Console.WriteLine($"\n\n -> {Name}");
            Console.Write("Local [1-9]: ");
            int spot = int.Parse(Console.ReadLine());

            if (grid.Grid[spot - 1] == '-') {
                grid.Grid[spot - 1] = PlayerMove;
                return GameManager.Oppositve(PlayerMove);
            } else {
                Console.WriteLine("Ocupado!!");
                return PlayerMove;
            }
        }
    }
}
