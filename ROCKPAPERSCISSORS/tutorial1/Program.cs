using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string inputPlayer ,inputCpu;
            int randomInt;
            
            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0, scoreCpu = 0;

                while (scoreCpu < 3 && scorePlayer < 3)
                {

                    Console.Write("Choose between ROCK , PAPER and SCISSORS : ");

                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCpu = "ROCK";
                            Console.WriteLine("Computer Chooses ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player WINS!!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n");
                                scoreCpu++;
                            }
                            break;


                        case 2:
                            inputCpu = "PAPER";
                            Console.WriteLine("Computer Chooses PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("Player WINS!!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n");
                                scoreCpu++;
                            }
                            break;


                        case 3:
                            inputCpu = "SCISSORS";
                            Console.WriteLine("Computer Chooses SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player WINS!!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n");
                                scoreCpu++;
                            }
                            break;

                        default:
                            Console.WriteLine("invalid input ");
                            break;


                    }
                    Console.WriteLine("Score \t Player:\t {0}\t CPU:\t {1}\n", scorePlayer,scoreCpu);
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WINS!!");
                }
                else if (scorePlayer == 3)
                {
                    Console.WriteLine("CPU WINS!!");

                }
                else
                {

                }

                Console.WriteLine("\nDo you want to play again?:(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }  
    }
} 