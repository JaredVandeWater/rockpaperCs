
using System;

namespace rockpaperCs
{
  class Game
  {
    private string _Options = "rps";
    private int _CPUNum = 0;
    public char PlayerChoice = 'w';
    private char _CPUChoice = 'w';
    public void Start()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Rock Paper Scissors");


      Play();
    }
    private void Play()
    {

      Console.WriteLine("Enter 'r', 'p' or 's'.");
      String Entry = Console.ReadLine();
      if (Entry[1]) { }
      PlayerChoice = Entry[0];
      if (PlayerChoice == 'r' || PlayerChoice == 'p' || PlayerChoice == 's')
      {

        var r = new Random();
        _CPUNum = r.Next(0, 3);
        var c = _Options[_CPUNum];
        _CPUChoice = c;

        Battle(PlayerChoice, _CPUChoice);
      }
      else if (PlayerChoice == 'q')
      {
        Console.Clear();
        Console.WriteLine("Until next time.");
        Environment.Exit(0);
      }
      else
      {
        Console.Clear();
        Console.WriteLine("Learn how to type you fool.");
        Play();
      }
    }
    private void Battle(char p, char c)
    {
      Console.Clear();
      Console.WriteLine($"You chose {PlayerChoice}, and I chose {_CPUChoice}.");

      if (p == c)
      {
        Console.WriteLine("We Tied!");
      }
      else
      {
        if (p == 'r' && c == 'p')
        {
          Console.WriteLine("You Won!");
          Play();
        }
        if (p == 'p' && c == 'r')
        {
          Console.WriteLine("You Won!");
          Play();
        }
        if (p == 's' && c == 'p')
        {
          Console.WriteLine("You Won!");
          Play();
        }

        Console.WriteLine("You Lost");
        Play();
      }


      Play();
    }
  }
}
