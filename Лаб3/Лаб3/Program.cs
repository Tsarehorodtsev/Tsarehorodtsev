using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб3
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            4. Guess the Number
            ");
            
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                case 4 :
                    GuessTheNumber();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            Console.WriteLine(@"
            There: farmer and wolf - 1
            There: farmer and cabbage - 2
            There: farmer and goat - 3
            There: farmer  - 4
            Back: farmer and wolf - 5
            Back: farmer and cabbage - 6
            Back: farmer and goat - 7
            Back: farmer  - 8
                              ");

            int[] array1 = { 3, 8, 2, 7, 1, 8, 3 };
            int[] array2 = { 3, 8, 1, 7, 2, 8, 3 };
            int[] array3 = new int [7]; 
            int i = 0;

            while (i < array3.Length)
            {
                Console.Write("Введите " + i + " действие ");
                array3[i] = int.Parse(Console.ReadLine());
                i++;
            }


            for (i = 0; i < array3.Length; i++)
            {

                if (array3[i] != array1[i] || array3[i] != array1[i])
                {
                    Console.WriteLine("\nДанные действия не являются решением задачи!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nПоздравляем, задача решена!");
                    break;
                }
            }
        }
        #endregion

        #region calculator
        static void Calculator()
        {
            Console.WriteLine(@"Пожалуйста, выберете действие:
            * - умножение
            / - деление
            + - сложение 
            - - вычетание
            ^ - возведение в степень
            ");

            string action = Console.ReadLine(); 
            double a, b; 
                
            Console.WriteLine("Введите первое значение");   
            a = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите второе значение"); 
            b = double.Parse(Console.ReadLine());

            double result;

            switch (action)
            {
                case "+":
                    result = a + b; 
                    Console.WriteLine("Результат " + result); 
                    break;

                case "-":
                    result = a - b;
                    Console.WriteLine("Результат " + result);
                    break;

                case "*":
                    result = a * b;
                    Console.WriteLine("Результат" + result);
                    break;

                case "/":
                    result = a / b;
                    Console.WriteLine("Результат " + result); 
                    break;

                case "^":
                    result =  Math.Pow(a, b);
                    Console.WriteLine("Результат " + result );
                    break;

                default:
                    break;

            }
     
           Console.ReadKey(); 

        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            int n = 5;
            Console.WriteLine("Введите число :");
            n = int.Parse(Console.ReadLine());

            if (n < 0) 
            { 
            throw new ArgumentException("Число является неверным. Используйте положительное.");
            }
            
            int result = 1;
            
            result = CalculateFact(n);
           
            Console.WriteLine(result);
           
            /* if (n != 0) {
                while (n > 1)
                {
                    result *= n--;
                }
            }
            Console.WriteLine(result);
            */
           
        }
        
        static int CalculateFact(int n)
        {
            if (n == 1) 
            {
                return 1;
            }

            return n * CalculateFact(n - 1);
            //throw new NotImplementedException();

        }

        static void GuessTheNumber() 
       {
            Random rand = new Random();
            int MaxValue = 100;
           
           int GuessNumber = rand.Next(MaxValue) + 1;
         
           int UsersNumber = 0;
         
           Console.WriteLine("Предпологаемое число находится в промежутке от 1 до "+ MaxValue);

           do
           {
               Console.Write("Введите число ");
               UsersNumber = int.Parse(Console.ReadLine());

               if (UsersNumber < GuessNumber)
               {
                   Console.WriteLine("\nДанное число меньше вашего");
               }

               if (UsersNumber > GuessNumber)
               {
                   Console.WriteLine("\nДанное число больше вашего");
               }
              
               if (UsersNumber == GuessNumber)
               {
                   Console.WriteLine("\nВы угадали число, поздравляем!");
                   Console.ReadKey();
               }

           } while (UsersNumber != GuessNumber);

       }


        #endregion
        }
    }
