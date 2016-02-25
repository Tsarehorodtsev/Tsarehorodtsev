using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._3
{
    enum CurrencyTypes { UAH, USD, EU }
    class Money
    {

        public int Amount { get; set; }
        public CurrencyTypes CurrencyType { get; set; }

        public Money()
            : this(0, 0)
        {

        }

        public Money(int amount, CurrencyTypes type)
        {
            Amount = amount;
            CurrencyType = type;
        }

        public static Money operator +(Money money_1, Money money_2)
        {
            Money sum_money = new Money();
            sum_money.Amount = money_1.Amount + money_2.Amount;
            return sum_money;
        }

        public static Money operator --(Money money_1)
        {
            money_1 = --money_1;
            return money_1;
        }

        public static Money operator *(Money money_1, int multiply)
        {
            Money sum_money = new Money();
            sum_money.Amount = money_1.Amount * multiply;
            return sum_money;
        }

        public static Money operator <(Money money_1, Money money_2)
        {
            return money_1 < money_2;
        }

        public static Money operator >(Money money_1, Money money_2)
        {
            return money_1 > money_2;
        }

        public static bool operator true(Money money_1)
        {
            if (money_1.CurrencyType != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(Money money_1)
        {
            if (money_1.CurrencyType == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static implicit operator double(Money money_1)
        {
            return money_1.Amount;
        }
        public static explicit operator string(Money money_1)
        {
            return money_1.Amount.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Money money_1 = new Money();
            money_1.Amount = 100;
            money_1.CurrencyType = CurrencyTypes.USD;
            
            Money money_2 = new Money();
            money_2.Amount = 500;
            money_2.CurrencyType = CurrencyTypes.USD;

            int choise;
            try
            {
                do
                {
                    {
                        Console.WriteLine(@"Please , choose the operation : 
                                        1 - Increase an amount (+) 
                                        2 - Decrease an amount (-)
                                        3 - Increase an amount (*)
                                        4 - Compare money
                                        ");
                        try
                        {
                            choise = int.Parse(Console.ReadLine());
                            double result;
                            switch (choise)
                            {
                                case 1:
                                    result = money_1 + money_2;
                                    Console.WriteLine("Result = " + result);
                                    break;

                                case 2:
                                    result = --money_1.Amount;
                                    Console.WriteLine("Result = " + result);
                                    break;

                                case 3:
                                    result = money_1.Amount * 3;
                                    Console.WriteLine("Result = " + result);
                                    break;

                                case 4:
                                    Console.WriteLine("money_1 = " + money_1.Amount);
                                    Console.WriteLine("money_2 = " + money_2.Amount);
                                    Console.WriteLine(money_1.Amount > money_2.Amount);
                                    break;

                                default:
                                    Console.WriteLine("Please, enter correct choise");
                                    break;
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error");
                        }
                        finally
                        {

                        }
                    }
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}