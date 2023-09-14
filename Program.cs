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
                Console.WriteLine("1. Get price of ticket");
                Console.WriteLine("Please press a key to continue or press 0 to quit.");
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
                            Console.WriteLine("Please enter your age: ");
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

                    default: 
                        quitMenu = true; 
                        break;

                }

            }
        }
    }
}