namespace COMP003A.Assignment5
{
    internal class Program
    {
        //This method displays the initial program to the user.
        //With void, it only prints text and does not need to pass data back to Main.
        static void DisplayIntroduction()
        { Console.WriteLine("Welcome to the Program Organizer! Your value will be doubled."); }

        //This greets the user by their name input and confirmed the value they entered.
        //The scope decision included the parameters "name" and "number" which are used to pass data from Main into this method.
        static void WelcomeMessage(string name, int number)
        {  Console.WriteLine($"Hello, {name}! You entered the number {number}. Doubling now."); }

        //The purpose of this method is ot calculate the given number the user inputed, doubling it.
        //The variable "finalAnswer" is local to this method, it is returned to Main so the result can be reused. 
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


                WelcomeMessage(userName, userNumber);
                int finalAnswer = CalculatedValue(userNumber);
                Console.WriteLine($"\nCalculated Result: {finalAnswer}");

                if (finalAnswer >= 10) { Console.WriteLine("The result is greater than or equal to 10!\n"); }
                else { Console.WriteLine("The result is 9 or less!\n"); }

                Console.Write("Would you like to run the program again? (y/n): ");
                string loopUser = Console.ReadLine();

                if (loopUser == "n") { loopRun = false; }
            }
            Console.WriteLine("\nProgram Ended.");
        }
    }
}// Methods exist because it organizes code into logical blocks, which enhances code readibility.
//For scope-related decisions, they control variable visibility, ensure memory efficiency, and prevent variable name conflicts.
