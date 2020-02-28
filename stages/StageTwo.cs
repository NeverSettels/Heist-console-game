using System;
using System.Drawing;
using Console = Colorful.Console;
using StyleSheet = Colorful.StyleSheet;

namespace Stage
{
  class StageTwo
  {
    private static string EnterText = "Lockpick: Hey, status update. The VIP room is nice, good lighting, and I love the carpet, and you would not believe how awesome the entertainment system is. There are two guards by the door to the vault and 4 people at the VIP table.";
    private static string FaceOption = "Face: Brain, I’m feeling lucky tonight I think I can wow the VIP’s with my poker skills and while everyone is marveling at my poker face the rest of the team can sneak in! ";
    private static string MuscleOption = "Muscle: Brain, I have a much better idea. I will pick a fight with the two guards at the door and disable them. Then I will flip the poker table over and give the Lockpick cover to get the door open.";
    private static string HackerOption = "Hacker: Ah, I have a different idea Brain. Not to disrespect my co-workers. Who I respect a lot. I could Hack into the Entertainment mainframe and cause such a commotion that no one will notice us slip through the locked door.";
    private static string LockpickOption = "Lockpick: I think I can pretend I am a maintenance man and ask the guards to let me fix the door. ";

    private static string FaceSuccess = "Face: So the rest of the team made it thanks to my amazing plan, though to be perfectly frank it didn't go quite like I imagined…. I got nervous and puked everywhere, I mean it was like that scene from the exorcist but all the VIPs were really nice about it.";
    private static string HackSuccess = "Hacker: So I was able to Hack into the entertainment mainframe. The rest of the team went ahead without me because the dance party got a little off the chain and I couldn’t leave it behind. I am currently on my way to the hospital.";
    private static string MuscleSuccess = "Muscle: Checking in. Everyone else made it in. I am still fighting the guards but we should be good once I giasd hjh j..a $1";
    private static string LockpickSuccess = "Security: This is Casino Security. We caught one of your guys trying to pretend he was a maintenance person. He immediately spilled the beans. Your band of cutely nicknamed criminals has been caught. You scum, the police on their way to your location.";

    public static void Start(string team)
    {
      Global.Typing();
      Console.WriteLine(EnterText, Color.Yellow);
      switch (team)

      {
        case "all":
          All();
          break;
        case "flm":
          Fml();
          break;
        case "flh":
          Flh();
          break;

        default:
          break;
      }

    }
    public static void All()
    {
      Global.Typing();
      Console.WriteLine(FaceOption, Color.Purple);
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine(MuscleOption, Color.Brown);
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine(HackerOption, Color.Cyan);
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine(LockpickOption, Color.Yellow);
      Console.WriteLine();

      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("M[a-z]*", Color.Brown);
      styleSheet.AddStyle("F[a-z]*", Color.Purple);
      styleSheet.AddStyle("H[a-z]*", Color.Cyan);
      styleSheet.AddStyle("L[a-z]*", Color.Orange);
      styleSheet.AddStyle("([|])*", Color.Green);

      string options = "| Go with The Muscle [M] | Go with The Face [F]  | Go with The Hacker [H] | Go with The Lockpick [L] |";

      Console.WriteLineStyled(options, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string selected = Console.ReadLine().ToLower();

      switch (selected)
      {
        case "f":
          //vomit, lose face
          Console.WriteLine(FaceSuccess);
          StageThree.Start("lmh");
          break;
        case "m":
          // fights guards -- lose muscle
          Console.WriteLine(MuscleSuccess);
          StageThree.Start("flh");
          break;

        case "l":
          //lockpick tries and gameover
          Console.WriteLine(LockpickSuccess);
          Global.GameOver();
          break;

        case "h":
          //hacks into entertainment center to distract. Lose hacker.
          Console.WriteLine(HackSuccess);
          StageThree.Start("flm");
          break;

        default:
          break;
      }

    }
    public static void Fml()
    {
      Global.Typing();
      Console.WriteLine(FaceOption, Color.Purple);
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine(MuscleOption, Color.Brown);
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine(LockpickOption, Color.Yellow);
      Console.WriteLine();

      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("M[a-z]*", Color.Brown);
      styleSheet.AddStyle("F[a-z]*", Color.Purple);
      styleSheet.AddStyle("H[a-z]*", Color.Cyan);
      styleSheet.AddStyle("L[a-z]*", Color.Orange);
      styleSheet.AddStyle("([|])*", Color.Green);

      string options = "| Go with The Muscle [M] | Go with The Face [F] | Go with The Lockpick [L] |";

      Console.WriteLineStyled(options, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string selected = Console.ReadLine().ToLower();

      switch (selected)
      {
        case "f":
          //vomit, lose face
          Console.WriteLine(FaceSuccess);
          StageThree.Start("lm");

          break;
        case "m":
          // fights guards -- lose muscle
          Console.WriteLine(MuscleSuccess);
          StageThree.Start("fl");
          break;

        case "l":
          //lockpick tries and gameover
          Console.WriteLine(LockpickSuccess);
          Global.GameOver();
          break;

        default:
          break;
      }

    }
    public static void Flh()
    {
      Global.Typing();
      Console.WriteLine(FaceOption, Color.Purple);
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine(HackerOption, Color.Cyan);
      Console.WriteLine();

      Global.Typing();
      Console.WriteLine(LockpickOption, Color.Yellow);
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
          //vomit, lose face
          Console.WriteLine(FaceSuccess);
          StageThree.Start("lh");

          break;

        case "l":
          //lockpick tries and gameover
          Console.WriteLine(LockpickSuccess);
          Global.GameOver();
          break;

        case "h":
          //hacks into entertainment center to distract. Lose hacker.
          Console.WriteLine(MuscleSuccess);
          StageThree.Start("fl");
          break;

        default:
          break;
      }

    }

  }
}