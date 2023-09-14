namespace MenuExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool userChoice = true;
           
            while (true)
            {
                Console.WriteLine("Welcome to main menu for testing differént tasks!");
                Console.WriteLine("Please press a key to continue or press 0 to quit.");
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                    userChoice = false;

            }
        }
    }
}