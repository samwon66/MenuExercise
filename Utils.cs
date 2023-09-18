using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercise
{
    //Class for helpers methods.
    public static class Utils
    {
        //Method for checking price for different ages of user. 
        //The price of ticket will be returned.
        public static int GetPrice(int age)
        {
            if (age < 5 || age > 100)
            {
                Console.WriteLine("It's free.\nPress enter to continue.");
                Console.ReadLine();
                return 0;
            }
            else if (age < 20)
            {
                Console.WriteLine("Junior: 80kr\nPress enter to continue.");
                Console.ReadLine();
                return 80;
            }
            else if (age > 64)
            {
                Console.WriteLine("Senior: 90\nPress enter to contnue.");
                Console.ReadLine();
                return 90;
            }
            else
            {
                Console.WriteLine("Normal: 120kr\nPress enter to continue.");
                Console.ReadLine();
                return 120;
            }
        }

        public static void CheckSubsLength(string[] subs)
        {
            if (subs.Length > 2)
            {
                Console.WriteLine($"The third word: {subs[2]}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your sentense have to be at least 3 words, please try again.");
                Console.ReadLine();
            }
        }

    }
}
