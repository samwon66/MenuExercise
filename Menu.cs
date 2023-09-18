using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercise
{
    public class Menu
    {

        //Method for printing out menu.
        public void RunMenu()
        {
            bool quitMenu = true;
            bool success = false;
            int userAge, userInput;
            string userString;

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
                success = int.TryParse(Console.ReadLine(), out userInput);
                if (success)
                {
                    switch (userInput)
                    {
                        case 0:
                        Console.WriteLine(">Bye!");
                        quitMenu = false;
                        break;

                        case 1:
                        Console.Clear();
                        Console.WriteLine(">Find out the price of your ticket.");
                        Console.Write(">Please enter your age: ");
                        success = int.TryParse(Console.ReadLine(), out userAge);
                            if (success) 
                            { 
                                Utils.GetPrice(userAge);
                        
                            }
                            else
                            {
                                Console.WriteLine(">You have entered an invalid amount, please try again.");
                                Console.ReadLine();
                            }

                        break;

                        case 2:
                        Console.Clear();
                        Console.WriteLine(">Get the total price of tickets.");
                        Console.Write(">How many tickets? ");
                        int amountOfTickets; 
                        success = int.TryParse(Console.ReadLine(), out amountOfTickets);
                        if (success)
                        {
                            int sum = 0;
                            for (int i = amountOfTickets; i > 0; i--)
                            {
                                Console.Write(">Please enter your age: ");
                                userAge = int.Parse(Console.ReadLine());
                                sum += Utils.GetPrice(userAge);
                            }
                            Console.WriteLine($">Amount of tickets: {amountOfTickets}\n>Total price: {sum}");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine(">You have entered an invalid amount, please try again.");
                            Console.ReadLine();
                        }
                        break;

                        case 3:
                        Console.Clear();
                        Console.WriteLine("Print out the sentense that user entered 10 times.");
                        Console.WriteLine(">Please enter a sentense: ");
                        userString = Console.ReadLine();
                        for (int i = 1; i < 11; i++)
                        {
                            Console.Write($"{i}.{userString},");
                        }
                        Console.ReadLine();
                        break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("Print out the third word of the sentense that entered by user.");
                            Console.WriteLine(">Please enter a sentense with at least 3 words.");
                            userString = Console.ReadLine();
                            string[] subs = userString.Split(' ');
                            Utils.CheckSubsLength(subs);
                            break;

                        default:
                        Console.WriteLine(">You have enter a invalid choice, please try again by pressing enter.");
                        Console.ReadLine();
                        break;

                    }
                    
                }
                else
                {
                    Console.WriteLine("You have entered a invalid choice, please try again");
                    Console.ReadLine();
                }

            }
        }

        
    }
}
