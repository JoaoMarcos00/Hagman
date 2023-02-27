using System;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "apple", "banana", "cherry", "orange", "grape" };
            Random random = new Random();
            string wordToGuess = words[random.Next(words.Length)];
            char[] letters = wordToGuess.ToCharArray();
            char[] display = new char[letters.Length];
            int attemptsLeft = 6;

            for (int i = 0; i < display.Length; i++)
            {
                display[i] = '_';
            }

            while (attemptsLeft > 0)
            {
                Console.WriteLine("Attempts left: " + attemptsLeft);
                Console.WriteLine(display);
                Console.Write("Guess a letter: ");
                char guess = Console.ReadLine()[0];

                bool found = false;
                for (int i = 0; i < letters.Length; i++)
                {
                    if (guess == letters[i])
                    {
                        display[i] = guess;
                        found = true;
                    }
                }

                if (!found)
                {
                    attemptsLeft--;
                }

                if (new string(display) == wordToGuess)
                {
                    Console.WriteLine("You win! The word was: " + wordToGuess);
                    return;
                }
            }

            Console.WriteLine("You lose! The word was: " + wordToGuess);
        }
    }
}
