namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void DisplayIntroduction()
        { Console.WriteLine("Welcome to the Program Organizer! Your value will be doubled."); }

        static int CalculatedValue(int doubledNumber)
        { int finalAnswer = doubledNumber * 2;
        return finalAnswer;}
        
        static void Main(string[] args)
        {
            DisplayIntroduction();

            bool loopRun = true;
            while (loopRun)
            {
                Console.Write("\nEnter your name: ");
                string userName = Console.ReadLine();
                Console.Write("Enter a number: ");
                int userNumber = int.Parse(Console.ReadLine());

                int finalAnswer = CalculatedValue(userNumber);
                Console.WriteLine($"\nCalculated Result: {finalAnswer}");

                if (finalAnswer >= 10) { Console.WriteLine("The result is greater than or equal to 10!\n"); }
                else { Console.WriteLine("The result is 9 or less!\n"); }

                Console.Write("Would you like to run the program again? (y/n)");
                string loopUser = Console.ReadLine();

                if (loopUser == "n") { loopRun = false; }
            }
            Console.WriteLine("\nProgram Ended.");
        }
    }
}
