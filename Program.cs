using System;
using TicTacToe.Entities;

namespace TicTacToe {
    class Program {
        static void Main(string[] args) {
            GridGame game = new GridGame();
            Player p1 = new Player('X');
            Player p2 = new Player('O');
            IAManager IA = new IAManager();

            int menu;

            do {
                Console.WriteLine(" 1 - Jogar vs IA");
                Console.WriteLine(" 2 - Jogar vs Player");
                Console.WriteLine(" 0 - Sair");

                Console.Write(" Escolha: ");
                menu = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (menu) {
                    // Versus IA
                    case 1: {
                        char turn = 'X';
                        while (p1.SetName()) { Console.Clear(); }

                        game.InitiateGrid();

                        do {
                            Console.Clear();
                            Console.WriteLine(game);

                            switch (turn) {
                                case 'X': {
                                    turn = p1.Move(game);
                                    break;
                                }
                                case 'O': {
                                    turn = IA.Move(game);
                                    break;
                                }
                            }

                            Console.Clear();
                        } while (GameManager.Verify(game, p1.Name, IA.Name) >= 3);

                        Console.Clear();
                        break;
                    }
                    // Versus Player
                    case 2: {
                        char turn = 'X';
                        while (p1.SetName()) { Console.Clear(); }
                        while (p2.SetName()) { Console.Clear(); }

                        game.InitiateGrid();

                        do {
                            Console.Clear();
                            Console.WriteLine(game);

                            switch (turn) {
                                case 'X': {
                                    turn = p1.Move(game);
                                    break;
                                }
                                case 'O': {
                                    turn = p2.Move(game);
                                    break;
                                }
                            }

                            Console.Clear();
                        } while (GameManager.Verify(game, p1.Name, p2.Name) >= 3);

                        Console.Clear();
                        break;
                    }
                }

            } while (menu != 0);
        }
    }
}
