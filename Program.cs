namespace MenuExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quitMenu = true;
           
            while (quitMenu == true)
            {
                Console.WriteLine("Welcome to main menu for testing differént tasks!");
                Console.WriteLine("Please press a key to continue or press 0 to quit.");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        quitMenu = false;
                        break;

                    default: 
                        quitMenu = true; 
                        break;

                }

            }
        }
    }
}