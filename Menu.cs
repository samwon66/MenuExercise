using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercise
{
    public class Menu
    {


        public void RunMenu()
        {
            bool quitMenu = true;

            while (quitMenu == true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to main menu for testing different tasks!");
                Console.WriteLine("1. Price of ticket");
                Console.WriteLine("2. The total price of tickets");
                Console.WriteLine("3. Iteration");
                Console.WriteLine("4. The third word");
                Console.WriteLine("0. Quit");
                Console.Write(">");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        Console.WriteLine("Bye!");
                        quitMenu = false;
                        break;

                    case 1:
                        Console.Write("Please enter your age: ");
                        int userAge = int.Parse(Console.ReadLine());
                        Utils.CheckAge(userAge);
                        //if (userAge < 5 || userAge > 100)
                        //{
                        //    Console.WriteLine("You are under 5 or over 100, your price will be free.\nPress enter to continue.");
                        //    Console.ReadLine();
                        //}
                        //else if (userAge < 20)
                        //{
                        //    Console.WriteLine("You are under 20, your price will be 80kr.\nPress enter to continue.");
                        //    Console.ReadLine();
                        //}
                        //else if (userAge > 64)
                        //{
                        //    Console.WriteLine("Yor're over 64, your price will be 90. \nPress enter to contnue.");
                        //    Console.ReadLine();
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Your price will be 120kr.\nPress enter to continue.");
                        //    Console.ReadLine();
                        //}

                        break;

                    case 2:
                        Console.Write("How many tickets? ");
                        int amountOfTickets = int.Parse(Console.ReadLine());
                        for (int i = amountOfTickets; i > 0; i--)
                        {

                        }
                        break;

                    case 3:
                        Console.WriteLine("Please enter a sentense: ");
                        string userString = Console.ReadLine();
                        for (int i = 1; i < 11; i++)
                        {
                            Console.Write($"{i}.{userString},");
                        }
                        Console.ReadLine();
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Wrong input, please try again by pressing enter.");
                        Console.ReadLine();
                        quitMenu = true;
                        break;

                }

            }
        }
    }
}
