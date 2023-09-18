using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercise
{
    public static class Utils
    {
        //Method for checking price for different ages of user. 
        //The price of ticket will be returned.
        public static int CheckAge(int age)
        {
            if (age < 5 || age > 100)
            {
                Console.WriteLine("You are under 5 or over 100, your price will be free.\nPress enter to continue.");
                Console.ReadLine();
                return 0;
            }
            else if (age < 20)
            {
                Console.WriteLine("You are under 20, your price will be 80kr.\nPress enter to continue.");
                Console.ReadLine();
                return 80;
            }
            else if (age > 64)
            {
                Console.WriteLine("Yor're over 64, your price will be 90. \nPress enter to contnue.");
                Console.ReadLine();
                return 90;
            }
            else
            {
                Console.WriteLine("Your price will be 120kr.\nPress enter to continue.");
                Console.ReadLine();
                return 120;
            }
        }
    }
}
