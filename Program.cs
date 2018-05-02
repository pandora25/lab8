using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool repeat = true;
                while (repeat)
                {
                    string[] names = { "mike", "anthony", "timo" };
                    string[] favriotfood = { "pizza", "noodles", "pork" };
                    string[] hometown = { "google", "yahoo", "facebook" };

                    Console.WriteLine("welcome to the c# class");
                    Console.WriteLine("what the student name would you like to know about ?");
                    Console.WriteLine("hint for the avaliable names are (1) mike, (2) anthony and (3) timo.\n");
                    int input1 = int.Parse(Console.ReadLine());

                    Console.WriteLine(names[input1 - 1] + " is exsit! )");

                    Console.WriteLine($"would else would you like to know about {names[input1 - 1]} ?");
                    Console.WriteLine("favriotfood or hometown ?");
                    string input2 = Console.ReadLine();

                    if (input2 == "hometown")
                    {
                        Console.WriteLine(hometown[input1 - 1]);
                    }
                    else if (input2 == "favriotfood")
                    {
                        Console.WriteLine(hometown[input1 - 1]);
                    }
                    else
                    {
                        Console.WriteLine("invalid entry !!!");
                    }

                    repeat = confirmation("would you like to know more? (y/n)");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid entry");
            }
        }
        public static bool confirmation(string message)
        {
            Console.WriteLine(message);
            string inputt = Console.ReadLine().ToLower();
            if (inputt == "y")
            {
                return true;
            }
            else if (inputt == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("invalid entry!!");
            }
            return confirmation(message);
        }
    }
}