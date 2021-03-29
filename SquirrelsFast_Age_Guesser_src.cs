using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquirrelsFast_Age_Guesser
{
    class Program
    {
        public static void Start(int age)
        {
            int inputNum = 0;
            string input = "0";

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("SquirrelsFast - Age Guesser");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hey! It's me Crunchy the squirrel!");
            Console.WriteLine("Let's play a game!");
            Console.Write("Guess how old I am, choose a number between 0 and 20: ");
            input = Console.ReadLine();
            inputNum = Int32.Parse(input);
            if (inputNum > age)
            {
                Console.WriteLine("A little last help, the number you choosed is greater than my age.");
                Console.Write("Try again: ");
                input = Console.ReadLine();
                inputNum = Int32.Parse(input);
                while (inputNum != age)
                {
                    TryAgain(inputNum, age);
                }
            }

            if (inputNum < age)
            {
                Console.WriteLine("A little last help, the number you choosed is lower than my age.");
                Console.Write("Try again: ");
                input = Console.ReadLine();
                inputNum = Int32.Parse(input);
                while (inputNum != age)
                {
                    TryAgain(inputNum, age);
                }
            }

            if (inputNum == age)
            {
                Finnish(age);
            }
        }

        public static int TryAgain(int num1, int num2)
        {
            int counter = 0;
            while (true)
            {
                if (num1 > num2 || num1 < num2)
                {
                    Console.Write("Wrong! Try again: ");
                    string input2 = Console.ReadLine();
                    num1 = Int32.Parse(input2);
                    counter++;
                }

                if (counter == 5 && num1 > num2)
                {
                    Console.WriteLine("I see you struggling...");
                    Console.WriteLine("So, the number you choosed is greater than my age.");
                    Console.Write("Try again: ");
                    string input2 = Console.ReadLine();
                    num1 = Int32.Parse(input2);
                }

                if (counter == 5 && num1 < num2)
                {
                        Console.WriteLine("I see you struggling...");
                        Console.WriteLine("So, the number you choosed is lower than my age.");
                        Console.Write("Try again: ");
                        string input2 = Console.ReadLine();
                        num1 = Int32.Parse(input2);
                }

                if (num1 == num2)
                {
                    Finnish(num2);
                }
            }
        }

        public static async void RickRoll()
        {
            System.Diagnostics.Process.Start("https://rickrolll.github.io/NOW_YOU_HAVE_BEEN_RICKROLLED.mp4");
            Environment.Exit(0);
        }

        public static async void EatYou()
        {
            Console.WriteLine("I got you, so now then... I'll eat your tasty CPU and RAM 4 forever!");
            Console.WriteLine("Cause it's better than any peanut and walnut! :P");
            Console.Title = " So I'm gonna' eat your PC";
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Also, I recommend you to check the task manager, and look at the CPU on the process tab! ;)");
            System.Threading.Thread.Sleep(7000);

            while (true)
            {
                Console.WriteLine("HAM");
                for (long myLong = -9223372036854775807; myLong < 9223372036854775807; myLong++)
                {
                    Console.WriteLine(myLong);
                    myLong++;
                }
                for (double myLong = 9223372036854775807; myLong > -9223372036854775807; myLong--)
                {
                    Console.WriteLine(myLong);
                    myLong--;
                }

                int[] array1 = new int[4096];
                int[] array2 = new int[4096];
                int[] array3 = new int[4096];
                int[] array4 = new int[4096];
                int[] array5 = new int[4096];

                int[] array6 = new int[4096];
                int[] array7 = new int[4096];
                int[] array8 = new int[4096];
                int[] array9 = new int[4096];
                int[] array10 = new int[4096];

                Console.WriteLine(array1);
                Console.WriteLine(array2);
                Console.WriteLine(array3);
                Console.WriteLine(array4);
                Console.WriteLine(array5);

                Console.WriteLine(array6);
                Console.WriteLine(array7);
                Console.WriteLine(array8);
                Console.WriteLine(array9);
                Console.WriteLine(array10);
            }
        }

        public static async void Switcher()
        {
            int userInput;
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Enter 1 for your gift.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Enter 2 to give me some gift.");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Enter 3 to EXIT.");
            System.Threading.Thread.Sleep(500);
            Console.Write("Enter here: ");
            userInput = Console.Read();

            if (userInput == 49) // ascii: 49 = 1
            {
                RickRoll();
            }

            if (userInput == 50) // ascii: 50 = 2
            {
                EatYou();
            }

            if (userInput == 51) // ascii : 51 = 3
            {
                Environment.Exit(0);
            }
        }

        public static int Finnish(int num5)
        {
            Console.WriteLine("Nice one, I am exactly {0} years old!", num5);
            Console.WriteLine("Because it's my birthday, you can give me some gifts, maybe...");
            Switcher();
            return 0;
        }

        static void Main()
        {
            Random rnd = new Random();
            int age = rnd.Next(0, 20);
            Console.Title = "SquirrelsFast - Age Guesser";
            for (int i = 0; i < 1; i++)
            {
                Start(age);
                i++;
            }
        }
    }
}
