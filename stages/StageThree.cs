
using System;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;

namespace Stage
{
  class StageThree
  {

    private static string FaceOption = "Face Option";
    private static string MuscleOption = "Muscle Option";
    private static string HackerOption = "Hacker Option";
    private static string LockpickOption = "Lockpick Option";


    public static void Start(string team)
    {
      switch (team)
      {
        case "lmh":
          Lmh();
          break;
        case "flm":
          Flm();
          break;
        case "flh":
          Flh();
          break;
        case "lm":
          Lm();
          break;
        case "fl":
          Fl();
          break;
        case "lh":
          Lh();
          break;
        default:
          //Do something esle
          break;
      }

    }

    public static void Lmh()
    {
      Global.Typing();
      Console.WriteLine("Muscle: Muscle: Hey I’m in here with the two nerds, the Lockpick and the Hacker. Real shape about the Face. They had such a great Face.");
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine("There is just one guard between us and the vault. Who do you want to take on tha guard?");
      Console.WriteLine();



      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("M[a-z]*", Color.Brown);
      styleSheet.AddStyle("F[a-z]*", Color.Purple);
      styleSheet.AddStyle("H[a-z]*", Color.Cyan);
      styleSheet.AddStyle("L[a-z]*", Color.Orange);
      styleSheet.AddStyle("([|])*", Color.Green);

      string options = "| Go with The Muscle [M]  | Go with The Hacker [H] | Go with The Lockpick [L] |";

      Console.WriteLineStyled(options, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string selected = Console.ReadLine().ToLower();

      switch (selected)
      {
        case "m":
          Global.Typing();
          Console.WriteLine("I took out the guard!");
          Console.WriteLine("The nerds opened the safe. We are home free!");
          Global.Win();
          //muscle option

          break;

        case "l":
          Global.GameOver();
          //lockpick option
          break;

        case "h":
          Global.Typing();
          Console.WriteLine("The hacker managed to take out the guard.");
          Console.WriteLine("But he died doing it. Pour one out for the homey. We are coming home with cash.");
          Global.Win();
          //hackerOption
          break;

        default:
          break;
      }

    }
    public static void Flh()
    {
      Global.Typing();
      Console.WriteLine("Face: Okay! We made it into the vault room! ");
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine("There is just one guard between us and the vault. Who do you want to take on tha guard?");
      Console.WriteLine();


      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("M[a-z]*", Color.Brown);
      styleSheet.AddStyle("F[a-z]*", Color.Purple);
      styleSheet.AddStyle("H[a-z]*", Color.Cyan);
      styleSheet.AddStyle("L[a-z]*", Color.Orange);
      styleSheet.AddStyle("([|])*", Color.Green);

      string options = "| Go with The Face [F]  | Go with The Hacker [H] | Go with The Lockpick [L] |";

      Console.WriteLineStyled(options, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string selected = Console.ReadLine().ToLower();

      switch (selected)
      {
        case "f":
          Global.Typing();
          Console.WriteLine("Face: Hey so the guard is one of us now! He wants to be called the EAGLE");
          Global.Win();


          break;

        case "l":
          Global.GameOver();
          break;

        case "h":
          Global.Typing();
          Console.WriteLine("The hacker managed to take out the guard.");
          Console.WriteLine("But he died doing it. Pour one out for the homey. We are coming home with cash.");
          Global.Win();
          break;

        default:
          break;
      }

    }
    public static void Lh()
    {
      Global.Typing();
      Console.WriteLine("Hacker: Okay! We made it into the vault room! ");
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine("Hacker: There is just one guard between us and the vault. Who do you want to take on tha guard?");
      Console.WriteLine();


      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("M[a-z]*", Color.Brown);
      styleSheet.AddStyle("F[a-z]*", Color.Purple);
      styleSheet.AddStyle("H[a-z]*", Color.Cyan);
      styleSheet.AddStyle("L[a-z]*", Color.Orange);
      styleSheet.AddStyle("([|])*", Color.Green);

      string options = "| Go with The Hacker [H] | Go with The Lockpick [L] |";

      Console.WriteLineStyled(options, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string selected = Console.ReadLine().ToLower();

      switch (selected)
      {

        case "l":
          Global.GameOver();
          break;

        case "h":
          Global.Typing();
          Console.WriteLine("Hacker: I managed to take out the guard.");
          Console.WriteLine("Hacker: But I am a dead man. Pour one out for me. Tell my mother I love her.");
          Global.Win();
          break;

        default:
          break;
      }

    }
    public static void Lm()
    {
      Global.Typing();
      Console.WriteLine("Muscle: Okay! We made it into the vault room! ");
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine("Muscle: There is just one guard between us and the vault. Who do you want to take on tha guard?");
      Console.WriteLine();


      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("M[a-z]*", Color.Brown);
      styleSheet.AddStyle("F[a-z]*", Color.Purple);
      styleSheet.AddStyle("H[a-z]*", Color.Cyan);
      styleSheet.AddStyle("L[a-z]*", Color.Orange);
      styleSheet.AddStyle("([|])*", Color.Green);

      string options = "| Go with The Muscle [M] | Go with The Lockpick [L] |";

      Console.WriteLineStyled(options, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string selected = Console.ReadLine().ToLower();

      switch (selected)
      {
        case "l":
          Global.GameOver();
          break;

        case "m":
          Global.Typing();
          Console.WriteLine("I took out the guard!");
          Console.WriteLine("The nerds opened the safe. We are home free!");
          Global.Win();
          break;

        default:
          break;
      }

    }
    public static void Flm()
    {
      Global.Typing();
      Console.WriteLine("Muscle: Okay! We made it into the vault room! ");
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine("Muscle: There is just one guard between us and the vault. Who do you want to take on tha guard?");
      Console.WriteLine();

      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("M[a-z]*", Color.Brown);
      styleSheet.AddStyle("F[a-z]*", Color.Purple);
      styleSheet.AddStyle("H[a-z]*", Color.Cyan);
      styleSheet.AddStyle("L[a-z]*", Color.Orange);
      styleSheet.AddStyle("([|])*", Color.Green);

      string options = "| Go with The Face [F]  | Go with The Muscle [M] | Go with The Lockpick [L] |";

      Console.WriteLineStyled(options, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string selected = Console.ReadLine().ToLower();

      switch (selected)
      {
        case "f":
          Global.Typing();
          Console.WriteLine("Face: Hey so the guard is one of us now! He wants to be called the EAGLE");
          Global.Win();


          break;

        case "l":
          Global.GameOver();
          break;

        case "m":
          Global.Typing();
          Console.WriteLine("I took out the guard!");
          Console.WriteLine("The nerds opened the safe. We are home free!");
          Global.Win();

          break;

        default:
          break;
      }

    }
    public static void Fl()
    {
      Console.WriteLine(FaceOption, Color.Purple);
      Console.WriteLine(LockpickOption, Color.Yellow);

      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("M[a-z]*", Color.Brown);
      styleSheet.AddStyle("F[a-z]*", Color.Purple);
      styleSheet.AddStyle("H[a-z]*", Color.Cyan);
      styleSheet.AddStyle("L[a-z]*", Color.Orange);
      styleSheet.AddStyle("([|])*", Color.Green);

      string options = "| Go with The Face [F]  | Go with The Lockpick [L] |";

      Console.WriteLineStyled(options, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string selected = Console.ReadLine().ToLower();

      switch (selected)
      {
        case "f":
          Global.Typing();
          Console.WriteLine("Face: Hey so the guard is one of us now! He wants to be called the EAGLE");
          Global.Win();

          break;

        case "l":
          Global.GameOver();
          break;
        default:
          break;
      }

    }

  }
}