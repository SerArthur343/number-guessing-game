using System.Collections.Concurrent;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int num = random.Next(1, 101);
            int playerGuess = 0;
            int guessCount = 0;

            Console.WriteLine("GUESS A NUMBER BETWEEN 1-100");

            while (playerGuess != num)
            {

                playerGuess = Convert.ToInt32(Console.ReadLine());

                if (playerGuess < num)
                {
                    Console.WriteLine("TOO LOW, GO HIGHER");
                    guessCount++;
                }

                else if (playerGuess > num)
                {
                    Console.WriteLine("TOO HIGH, GO LOWER");
                    guessCount++;
                }

                else
                {
                    Console.WriteLine($"CONGRATULATIONS, YOU'VE FOUND THE CORRECT NUMBER! THE CORRECT NUMBER IS {num}");
                    Console.WriteLine($"IT TOOK YOU {guessCount} WRONG GUESSES TO FIND THE CORRECT ANSWER");
                    Console.WriteLine("PLAY AGAIN? Y/N");

                    string playAgain = Console.ReadLine();
                    playAgain = playAgain.ToUpper();

                    if (playAgain == "Y")
                    {
                        random = new Random();
                        num = random.Next(1, 101);
                        playerGuess = 0;
                        guessCount = 0;

                        Console.WriteLine("GUESS A NUMBER BETWEEN 1-100");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("PRESS ENTER TO EXIT");
            Console.ReadLine();
        }
    }
}
