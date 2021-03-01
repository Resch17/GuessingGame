using System;
using System.Threading;

Main();

void Main()
{
  Console.WriteLine("Guess the secret number!");
  string userInput = Console.ReadLine();
  int userGuess = 0;
  try
  {
    userGuess = Int32.Parse(userInput);
  }
  catch
  {
    Console.WriteLine("Nah, that didn't work. Try with a normal number, weirdo...");
    Thread.Sleep(2000);
    Console.Clear();
    Main();
  }
  Console.WriteLine($"You guessed {userGuess}");
}