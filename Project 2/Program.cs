using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, fullName, howFeel;
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last Name");
            lastName = Console.ReadLine();

            fullName = String.Concat(firstName, " ", lastName);

            Console.WriteLine("Hello" + fullName + ", Are you doing well today");
            howFeel = Console.ReadLine();

            if (howFeel == "yes" || howFeel == "Yes" || howFeel == "YES")
            {
                Console.WriteLine("That is wonderful news" + fullName + "! So am I.");
                Console.Read();
            }
            else if (howFeel == "no" || howFeel == "No" || howFeel == "NO")
            {
                Console.WriteLine("I'm sorry to hear that" + fullName + "That really is a shame.");
                Console.Read();
            }
            else
            {
                Console.WriteLine("I'm sorry, I am not programmed to interpret that response.");
                Console.Read();
            }
        }
    }
}
