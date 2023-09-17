namespace MenuExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quitMenu = true;
           
            while (quitMenu == true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to main menu for testing different tasks!");
                Console.WriteLine("1. Price of ticket");
                Console.WriteLine("2. The total price of tickets");
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
                        if (input == 1)
                        {
                            Console.Write("Please enter your age: ");
                            int userAge = int.Parse(Console.ReadLine());
                            if (userAge < 20)
                            {
                                Console.WriteLine("You are under 20, your price will be 80kr.\nPress enter to continue.");
                                Console.ReadLine();
                            }
                            else if (userAge > 64)
                            {
                                Console.WriteLine("You are over 64, your price will be 90kr.\nPress enter to continue.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Your price will be 120kr.\nPress enter to continue.");
                                Console.ReadLine();
                            }
                        }
                        break;

                    case 2:
                        Console.Write("How many tickets? ");
                        int amountOfTickets = int.Parse(Console.ReadLine());
                        for (int i = amountOfTickets; i > 0; i--)
                        {
                            
                        }
                        break;

                    default: 
                        Console.WriteLine("Wrong input, please try again by pressing enter.");
                        Console.ReadLine() ;
                        quitMenu = true; 
                        break;

                }

            }
        }
    }
}