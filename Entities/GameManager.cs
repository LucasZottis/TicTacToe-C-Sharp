using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Entities {
    static class GameManager {
        public static char Oppositve(char playerMove) {
            if (playerMove == 'X') {
                return 'O';
            } else {
                return 'X';
            }
        }
        public static int Verify(GridGame game, string name1, string name2) {
            int winner = 3, tie = 0;
            // Verifica linhas;
            for (int i = 0; i < 3; i++) {
                if (game.Grid[i * 3] == game.Grid[i * 3 + 1] && game.Grid[i * 3] == game.Grid[i * 3 + 2]) {
                    if (game.Grid[i * 3] == 'X') winner = 1;
                    if (game.Grid[i * 3] == 'O') winner = 2;
                }
            }
            // Verifica Colunas:
            for (int i = 0; i < 3; i++) {
                if (game.Grid[i] == game.Grid[i + 3] && game.Grid[i] == game.Grid[i + 6]) {
                    if (game.Grid[i] == 'X') winner = 1;
                    if (game.Grid[i] == 'O') winner = 2;
                }
            }
            // Verifica Diagonal Principal:
            if (game.Grid[0] == game.Grid[4] && game.Grid[0] == game.Grid[8]) {
                if (game.Grid[0] == 'X') winner = 1;
                if (game.Grid[0] == 'O') winner = 2;
            }
            // Verifica Diagonal Secundária
            if (game.Grid[2] == game.Grid[4] && game.Grid[2] == game.Grid[6]) {
                if (game.Grid[2] == 'X') winner = 1;
                if (game.Grid[2] == 'O') winner = 2;
            }
            // Verifica se deu empate
            if (game.Grid[0] != '-' && game.Grid[1] != '-' && game.Grid[2] != '-' &&
                game.Grid[3] != '-' && game.Grid[4] != '-' && game.Grid[5] != '-' &&
                game.Grid[6] != '-' && game.Grid[7] != '-' && game.Grid[8] != '-') { winner = 0; }

            Console.WriteLine(game);

            switch (winner) {
                case 1: {
                    Console.WriteLine($"\n{name1} ganhou!!");
                    Console.ReadKey();
                    break;
                }
                case 2: {
                    Console.WriteLine($"\n{name2} ganhou!!");
                    Console.ReadKey();
                    break;
                }
                case 0: {
                    Console.WriteLine($"\n{name1} e {name2} empataram!!");
                    Console.ReadKey();
                    break;
                }
            }
            return winner;
        }
    }
}
