using System;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;

namespace Stage
{
  class StageOne
  {
    public static void Start()
    {
      Console.WriteLine("\n \n");
      Console.WriteLine(@"
      Your is infiltrating the Casino.....
      Waiting for their communication to confirm they have 
      successfully made it to the rendezvous point.");

      Typing();

      Console.WriteLine("\n Brain, you there? Over...", Color.Purple);
      Console.WriteLine("\n Press [Y] for yes, [N] for no");
      string inputOne = Console.ReadLine().ToLower();

      Typing();
      if (inputOne == "y")
      {
        Console.WriteLine("Good to hear from you brain!", Color.Purple);
      }
      else if (inputOne == "n")
      {
        Console.WriteLine("That's not funny....", Color.Purple);
      }
      SlotRoom();

    }

    public static void Typing()
    {
      for (int i = 0; i < 5; i++)
      {
        Console.Write(".");
        System.Threading.Thread.Sleep(500);
      }
      Console.WriteLine();
    }

    public static void SlotRoom()
    {
      Console.WriteLine(@"", Color.Purple);
      //talk about room.
      //present options
      //check options
      // start stage two. with perams
    }

  }
}