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
    }
}
