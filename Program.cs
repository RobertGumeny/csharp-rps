using System;

namespace csharp_rps
{
  class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");
      Console.WriteLine("Would you like to start a new game? Y/N");
      // NOTE Initialize game if player selects "Y" for yes, establish basic variables.
      string startGame = Console.ReadLine();
      bool playing = startGame.ToLower() == "y";
      int playerChoiceInt = 0;
      int playerWins = 0;
      int playerLosses = 0;
      int playerDraws = 0;
      int gamesPlayed = 0;
      Random random = new Random();
      int computerChoiceInt = random.Next(1, 4);
      // NOTE Game begins
      while (playing)
      {
        Console.WriteLine("Please select rock, paper, or scissors");
        string playerChoiceStr = Console.ReadLine();
        // NOTE Assign integer to player selection so we can compare it to random computer choice
        if (playerChoiceStr.ToLower() == "rock")
        {
          playerChoiceInt = 1;
        }
        else if (playerChoiceStr.ToLower() == "paper")
        {
          playerChoiceInt = 2;
        }
        else if (playerChoiceStr.ToLower() == "scissors")
        {
          playerChoiceInt = 3;
        }
        else
        {
          Console.WriteLine("Please make a valid selection");
          continue;
        }
        // NOTE Write computer selection to console so player can visualize it
        if (computerChoiceInt == 1)
        {
          Console.WriteLine($"Player selected {playerChoiceStr}");
          Console.WriteLine("Computer selected rock");
        }
        if (computerChoiceInt == 2)
        {
          Console.WriteLine($"Player selected {playerChoiceStr}");
          Console.WriteLine("Computer selected paper");
        }
        if (computerChoiceInt == 3)
        {
          Console.WriteLine($"Player selected {playerChoiceStr}");
          Console.WriteLine("Computer selected scissors");
        }
        // SECTION Figure out who wins.
        if (computerChoiceInt == 1) // Rock
        {
          if (playerChoiceInt == 1) // Rock
          {
            Console.WriteLine("Tie Game!");
            playerDraws++;
          }
          if (playerChoiceInt == 2) // Paper
          {
            Console.WriteLine("Player Wins!");
            playerWins++;
          }
          if (playerChoiceInt == 3) // Scissors
          {
            Console.WriteLine("Computer Wins!");
            playerLosses++;
          }
        }
        if (computerChoiceInt == 2) // Paper
        {
          if (playerChoiceInt == 2) // Paper
          {
            Console.WriteLine("Tie Game!");
            playerDraws++;
          }
          if (playerChoiceInt == 3) // Scissors
          {
            Console.WriteLine("Player Wins!");
            playerWins++;
          }
          if (playerChoiceInt == 1) // Rock
          {
            Console.WriteLine("Computer Wins!");
            playerLosses++;
          }
        }
        if (computerChoiceInt == 3) // Scissors
        {
          if (playerChoiceInt == 3) // Scissors
          {
            Console.WriteLine("Tie Game!");
            playerDraws++;
          }
          if (playerChoiceInt == 1) // Rock
          {
            Console.WriteLine("Player Wins!");
            playerWins++;
          }
          if (playerChoiceInt == 2) // Paper
          {
            Console.WriteLine("Computer Wins!");
            playerLosses++;
          }
        }
        // !SECTION
        gamesPlayed++;
        float playerWinPct = (float)playerWins / gamesPlayed;
        Console.WriteLine($"Player W/L/D: {playerWins}/{playerLosses}/{playerDraws}");
        Console.WriteLine($"Games Played: {gamesPlayed} Player Win %: % {playerWinPct * 100}");
        Console.WriteLine("Would you like to play again? Y/N");
        string playAgain = Console.ReadLine();
        if (playAgain.ToLower() == "y")
        {
          computerChoiceInt = random.Next(1, 4);
        }
        else
        {

          playing = false;
        }
      }
      Console.WriteLine("Thanks for playing!");
    }
  }
}
