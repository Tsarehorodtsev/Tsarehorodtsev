using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Лаб5
{
    class Program
    {
        static void Main(string[] args)
        {
            long NumberOfChoise;
            Console.WriteLine(@"Please,  type the number:
            1. Binary_transformer
            2. Unary_transform
            3. Music
            4. Morse_code()
            ");

            NumberOfChoise = long.Parse(Console.ReadLine());
            switch (NumberOfChoise)
            {
                case 1:
                    Binary_transform();
                    Console.WriteLine("");
                    break;
                case 2:
                    Unary_transform();
                    Console.WriteLine("");
                    break;
                case 3:
                    Music();
                    Console.WriteLine("");
                    break;
                case 4 :
                    Morse_code();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }




        static void Binary_transform()
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Please, enter the number");
            Console.ForegroundColor = ConsoleColor.White;

            int number = int.Parse(Console.ReadLine());
            string binary_number = Convert.ToString(number, 2);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Transformed number " + binary_number);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }


        static void Unary_transform()
        {

            uint a;
            uint b;
            string unary_number_a = null;
            string unary_number_b = null;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Type first positive integer");
            Console.ForegroundColor = ConsoleColor.White;
            a = uint.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Type second positive integer");
            Console.ForegroundColor = ConsoleColor.White;
            b = uint.Parse(Console.ReadLine());



            for (int i = 0; i < a; i++)
            {
                unary_number_a += "1";
            }


            for (int i = 0; i < b; i++)
            {
                unary_number_b += "1";
            }


            string numbers = unary_number_a + '#' + unary_number_b;


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Unary number a " + unary_number_a + "\nUnary number b " + unary_number_b);
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 1; i <= numbers.Length; i++)
            {
                numbers = numbers.Replace("1#1", "#");
            }
            numbers = numbers.Trim(new Char[] { '#' });

            Console.WriteLine(numbers);



            Console.ReadKey();


        }

        static void Morse_code()
        {

            Thread.Sleep(1000);
              
            Console.Beep(1000, 200);
            Thread.Sleep(50);

            Console.Beep(1000, 200);
            Thread.Sleep(50);

            Console.Beep(1000, 200);
            Thread.Sleep(50);

            Console.Beep(1000, 750);
            Thread.Sleep(50);

            Console.Beep(1000, 750);
            Thread.Sleep(50);

            Console.Beep(1000, 750);
            Thread.Sleep(50);

            Console.Beep(1000, 200);
            Thread.Sleep(50);

            Console.Beep(1000, 200);
            Thread.Sleep(50);

            Console.Beep(1000, 200);
            Thread.Sleep(50);

        }


        static void Music() 
        {
            // Metallica - Nothing else matters
            Thread.Sleep(1000);

            Console.Beep(300, 550);

            Console.Beep(500, 550);

            Console.Beep(750, 550);

            Console.Beep(1000, 550);

            Console.Beep(750, 550);

            Console.Beep(500, 550);
            Thread.Sleep(75);

            Console.Beep(300, 550);

            Console.Beep(500, 550);

            Console.Beep(750, 550);

            Console.Beep(1000, 550);

            Console.Beep(750, 550);

            Console.Beep(500, 550);
            Thread.Sleep(75);

        }
  }
}