using System;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;
using Stage;


namespace Heist
{
  class Program
  {
    static void Main()
    {
      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("S[a-z]*", Color.Green);
      styleSheet.AddStyle("M[a-z]*", Color.Teal);
      styleSheet.AddStyle("Q[a-z]*", Color.Red);
      string introMenu = "Press [S] to start, [M] to meet your team, [Q] to quit.";


      //START GAME
      Global.Title();
      Console.WriteLine("You are the brain to the heist of the century", Color.Green);
      Console.WriteLineStyled(introMenu, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string input = Console.ReadLine().ToLower();

      if (input == "s")
      {
        StageOne.Start();
      }
      else if (input == "m")
      {
        Console.WriteLine("Coming soon");
        Console.WriteLine("\n \n \n");
        Main();
      }
      else if (input == "q")
      {

      }
      else
      {
        Console.WriteAscii("Invalid input:", Color.Red);
        Console.WriteAscii("Try again", Color.Red);
        Console.WriteLine("----------------------------------------------------------------------", Color.Red);
        Console.WriteLine("\n \n");
        Main();
      }

    }

  }
}
