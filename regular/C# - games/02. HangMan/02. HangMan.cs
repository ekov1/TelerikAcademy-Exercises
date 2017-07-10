using System;
using System.IO;
using System.Threading;

namespace _02.HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();//random number generator

            string[] dictionary = File.ReadAllLines("words.txt");
            string word = "";

            word = GenerateAWord(rng, dictionary);

            // Game Loop
            //  UI -> descriptive text, how many lives, word progress...
            //  read letter
            //  check if user has input a letter
            //  main logic
            // TODO: Game Over Condotions
            // TODO: Game Won Conditions

            int numberOfLives = 6;
            char[] currentGuess = new string('_', word.Length).ToCharArray();
            string allGuessedLetters = "";
            bool isGameOver = false;

            while (!isGameOver)
            {
                GameUI(numberOfLives, currentGuess, allGuessedLetters);

                string guessedLetter;
                bool isWrongInput;

                InputController(out guessedLetter, out isWrongInput);

                // Main Logic
                MainGameLogic(word, ref numberOfLives, currentGuess, ref allGuessedLetters, guessedLetter, isWrongInput);

                isGameOver = GameOverCondition(word, numberOfLives, isGameOver);

                // Check if CurrentGuess has any _
                isGameOver = GameWonCondition(word, currentGuess, isGameOver);

            }
        }

        private static bool GameWonCondition(string word, char[] currentGuess, bool isGameOver)
        {
            if (new string(currentGuess) == word)
            {
                Console.Clear();
                Console.WriteLine("Game Won!");
                Console.WriteLine("The correct word was: {0}", word);
                isGameOver = true;
            }

            return isGameOver;
        }

        private static bool GameOverCondition(string word, int numberOfLives, bool isGameOver)
        {
            if (numberOfLives == 0)
            {
                Console.Clear();
                Console.WriteLine("Game Over!");
                Console.WriteLine("The correct word was: {0}", word);
                isGameOver = true;
            }

            return isGameOver;
        }

        private static void MainGameLogic(string word, ref int numberOfLives, char[] currentGuess, ref string allGuessedLetters, string guessedLetter, bool isWrongInput)
        {
            bool isLetterCorrect = false;
            char letter;

            if (isWrongInput == false)
            {
                allGuessedLetters += " " + guessedLetter;
                letter = Convert.ToChar(guessedLetter);

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter)
                    {
                        currentGuess[i] = letter;
                        isLetterCorrect = true;
                        break;
                    }
                }

                if (isLetterCorrect == false)
                {
                    numberOfLives--;
                }
            }
        }

        private static void InputController(out string guessedLetter, out bool isWrongInput)
        {
            guessedLetter = Console.ReadLine();
            guessedLetter = guessedLetter.ToLower();
            isWrongInput = false;
            if (guessedLetter.Length == 0 || guessedLetter.Length > 1
                || !Char.IsLetter(Convert.ToChar(guessedLetter)))
            {
                Console.Clear();
                Console.WriteLine(" Wrong Input! Please, input a single letter!");
                Thread.Sleep(2500);
                isWrongInput = true;
            }
        }

        private static void GameUI(int numberOfLives, char[] currentGuess, string allGuessedLetters)
        {
            Console.Clear();

            for (int i = 0; i < currentGuess.Length; i++)
            {
                Console.Write(" " + currentGuess[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Number of Lives: {0}", numberOfLives);
            Console.WriteLine();
            Console.WriteLine(" Guessed Letters: {0}", allGuessedLetters);
            Console.WriteLine();
            Console.WriteLine(" Please input a letter.");
            Console.SetCursorPosition(1, 7);
        }

        private static string GenerateAWord(Random rng, string[] dictionary)
        {
            string word;
            do
            {
                int randomWordNumber = rng.Next(0, dictionary.Length);
                word = dictionary[randomWordNumber];
            } while (word.Length <= 3);
            return word;
        }
    }
}
