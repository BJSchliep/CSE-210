using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Console.WriteLine("What is you first name");
        //     Console.WriteLine("My name is Brandon");

        //     Console.Write("What is your first name?");
        //     string first_name = Console.ReadLine();
        //     Console.Write("What is your last name? ");
        //     string last_name = Console.ReadLine();
        //     Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

            Console.Write("What is your grade percentage? ");
            string answer = Console.ReadLine();
            int percent = int.Parse(answer);
            if (percent >= 80)
            {
                if (percent >= 90)
                {
                    Console.Write("Your Grade is an A");
                }
                else{
                    Console.Write("Your grade is a B");
                }
            }
            else if (percent >= 60)
            {
                if (percent >= 70)
                {
                    Console.Write("Your grade is a C");
                }
                else
                {
                    Console.Write("Your grade is a D");
                }
            }
            else
            {
                Console.Write("You have an F");
            }

        }
    }
}