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
      successfully made it to the rendezvous point.", Color.Green);
      Console.WriteLine();

      Global.Typing();

      Console.WriteLine("\nFace: Brain, you there? Over...", Color.Purple);
      Console.WriteLine("\n Press [Y] for yes, [N] for no");
      Console.Write("Enter : ", Color.Green);
      string inputOne = Console.ReadLine().ToLower();

      Global.Typing();
      if (inputOne == "y")
      {
        Console.WriteLine("Face: Good to hear from you brain!", Color.Purple);
      }
      else if (inputOne == "n")
      {
        Console.WriteLine("Face: That's not funny....", Color.Purple);
      }
      SlotRoom();

    }

    public static void SlotRoom()
    {
      StyleSheet styleSheet = new StyleSheet(Color.White);
      styleSheet.AddStyle("M[a-z]*", Color.Brown);
      styleSheet.AddStyle("F[a-z]*", Color.Purple);
      styleSheet.AddStyle("H[a-z]*", Color.Cyan);
      styleSheet.AddStyle("L[a-z]*", Color.Orange);
      styleSheet.AddStyle("([|])*", Color.Green);
      string options = "| Go with The Muscle [M] | Go with The Face [F]  | Go with The Hacker [H] | Go with The Lockpick [L] |";
      Console.WriteLine(@"Face: Hey brain its The FACE, we have gathered by the Jurassic park slot machine it looks like a winner. Muscle and Lockpick are scouting the room we’ll check in on a sec. ", Color.Purple);
      Console.WriteLine();
      Global.Typing();
      Console.WriteLine(@"Muscle: The MUSCLE Here!, we’re on the main casino floor with all the slot machines. I see several options for us to make it into the VIP room that's connected  to the vault. There is a guard by the door he was talking about “pineapples” or something I could take them.\n", Color.Brown);
      Console.WriteLine();
      Global.Typing();
      Console.WriteLine(@"Hacker: Hi… its.. Um.. me the HACKER, I could probably Hack the um jurassic park machine and create a distraction.\n ", Color.Cyan);
      Console.WriteLine();
      Global.Typing();
      Console.WriteLine(@"Face: Or a better Option is using my natural charm and ability to win at the poker table and get invited to the VIP room.\n", Color.Purple);
      Console.WriteLine();
      Global.Typing();
      Console.WriteLine(@"Lockpick: Finally I, the LOCKPICK, could pool the fire ’larm and use the commotion to sneak into the next room. What do you thank we should dew?.\n", Color.Orange);
      Console.WriteLine();
      Console.WriteLine();

      Console.WriteLineStyled(options, styleSheet);
      Console.Write("Enter : ", Color.Green);
      string selected = Console.ReadLine().ToLower();
      switch (selected)
      {
        case "m":
          //drug gaurd -- lose muscle
          Global.Typing();
          Console.WriteLine(@"Muscle: Hey I got good news and I got bad news, the good first, we made it into the VIP room and no one suspects anything yet. The bad is that Muscle Absolutely and spectacularly failed to drug the guard subtly and ended up decking him in the face and getting arrested soooo one less way to divy up the loot I guess…. ", Color.Purple);
          StageTwo.Start("flh");
          break;
        case "f":
          Global.Typing();
          Random rand = new Random();
          int pokerCheck = rand.Next(1, 4);
          if (pokerCheck == 1)
          {
            Console.WriteLine(@"Face: So I have good news and bad news… The good news is that everyone is okay. The bad news is I lost all of your money at the Poker table and now we are heading to sharies to grab a bite to eat before we call it a day. ", Color.Purple);
            Console.WriteLine();
            Global.GameOver();
          }
          else
          {
            Console.WriteLine(@"Face: So good news! We are in the VIP room and everyone thinks I am a high roller. I hate to brag but I am amazing at Poker.", Color.Purple);
            Console.WriteLine();
            StageTwo.Start("all");
          }
          // win roullete -- everyone in chance
          break;
        case "l":
          // fire alarm -- lose
          Global.Typing();
          Console.WriteLine(@"Casino: This is Casino Security. We caught one of your guys trying to pull the fire alarm and he spilled the beans. Your band of cutely nicknamed criminals has been caught. You scum, the police on their way to your location.", Color.Red);
          Global.GameOver();
          //lose
          break;
        case "h":
          // Hack slots -- lose hacker 
          Global.Typing();
          Console.WriteLine(@"Muscle: Brain the hacker is dead, I repeat the hacker is dead. He succeeded in hacking Jurassic Payout but was trampled by the crowd of jerries trying to collect all the money the damn machine spat out. It was Chaos I tell you, I never knew happy vomiting was such an affliction. On a different note, we made it into the VIP room, unnoticed, the mission is a go 3===D ~~~~ (sploosh)", Color.Brown);
          StageTwo.Start("flm");
          break;
        default:
          //error
          Console.WriteLine("Default case");
          break;
      }

    }

  }
}