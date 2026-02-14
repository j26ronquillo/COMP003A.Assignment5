namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void DisplayIntroduction()
        { Console.WriteLine("Welcome to the Program Organizer!\n"); }
        
        
        static void Main(string[] args)
        {
            DisplayIntroduction();

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
        }
    }
}
