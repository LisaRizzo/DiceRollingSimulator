using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Rolling_Simulator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Las Vegas!");
      Console.WriteLine("Enter the number of sides for a pair of dice:");
      int sides = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter the number dice:");
      int dice = Convert.ToInt32(Console.ReadLine());

      int count = 1;
      Boolean run = true;
      while (run == true)
      {
        Console.WriteLine("Roll the dice? Y/N");
        string input = Console.ReadLine();
        input.ToLower();

          if (input == "n")
          {
            Console.WriteLine("Bye!");
            Console.ReadLine();
            break;
          }
          else if (input == "y")
          {
            //Store the Random object as a member variable someplace.
            Random randomNumber = new Random();
            Random rando = new Random();
            //Sum of dice roll
            Roll(sides, dice, randomNumber);
            Console.WriteLine("Roll #: " + count++);
            Console.WriteLine();
            continue;
          }
      }
    }


    //Method for generating a random number.
    //Random number needs min, max inclusive.
    public static int GetRandom(int min, int max, Random rand)
    {
      int output = rand.Next(min, max + 1);
      Console.WriteLine("Dice: " + output);
      return output;
    }

    /*Roll method taking into consideration sides and dice
      Use sides to determine the max number of each dice you roll
      Use dice to determine how many dice you roll at once
      Return the total of all rolls */
    public static int Roll(int sides, int dice, Random randomNumber)
    {
      int result = 0;

      for (int i = 0; i < dice; i++)
      {
        result += GetRandom(1, sides, randomNumber);
      }

        //Display dice roll results
        if (result == 2)
        {
          Console.WriteLine("You rolled: " + result + " \'Snake Eyes!\'");  
        }
        else if (result == 12)
        {
          Console.WriteLine("You rolled: " + result + " \'Box Cars!\'");
        }
        else
        {
          Console.WriteLine("You rolled: " + result);
        }

        //Display result CRAPS! on 2, 3, 12
        if (result == 2 || result == 3 || result == 12)
        {
          Console.WriteLine("CRAPS!");
        }
      return result;
    }
 
    public static Boolean Continue()
    {
      Console.WriteLine("Continue? Y/N");
      string input = Console.ReadLine();
      Boolean run = false;
      input.ToLower();

        if (input == "n")
        {
          Console.WriteLine("Good bye");
          run = true;
        }
        else if (input == "y")
        {
          run = false;
        }
        else
        {
          Console.WriteLine("I'm sorry I didn't under your input let's try that again");
          run = Continue();
        }

      return run;
    }
  }
}

