using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._2
{
    public class Base<T> where T : new()
    {
        static Base()
        {
            Console.WriteLine("First base class");
            T basic = new T();
        }
    }

    public sealed class Derived : Base<Derived>
    {
        public Derived()
        {
            Console.WriteLine("Derived class Base");
        }
    }

    public class Base_public_field<T> where T : new()
    {
        private T _instance;
        public T Instance
        {
            get
            {
                Console.WriteLine("Public field");
                _instance = new T();
                return _instance;
            }
        }
        static Base_public_field()
        {
            System.Console.WriteLine("  Base static constructor");
            T intern = new T();
        }
    }

    public sealed class Derived_public_field : Base_public_field<Derived_public_field>
    {
        public Derived_public_field()
        {
            Console.WriteLine("Derived_public_field");
        }
    }


    public class Base_static_field<T> where T : new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                Console.WriteLine("Static field");
                _instance = new T();
                return _instance;
            }
        }
        protected Base_static_field()
        {
            Console.WriteLine("Base_static_field");
        }
    }

    public sealed class Derived_static_field : Base_static_field<Derived_static_field>
    {
        public Derived_static_field()
        {
            Console.WriteLine("Derived constructor");
        }
    }

    public class Base_publ<T> where T : new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                Console.WriteLine("Static field");
                _instance = new T();
                return _instance;
            }
        }
        static Base_publ()
        {
            Console.WriteLine("Base_publ");
        }
    }

    public sealed class Derived_publ : Base_publ<Derived_publ>
    {
        public Derived_publ()
        {
            Console.WriteLine("Derived_publ");
        }
    }

    public static class Curry_list
    {
        public static Func<TArg2, Func<TArgl, TResult>> Bnd<TArgl, TArg2, TResult>(this Func<TArgl, TArg2, TResult> f)
        {
            return (y) => ((x) => f(x, y));
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.WriteLine(@"Please,  type the number:

                        Generics      Class Derived : Base<Derived>
                        1.  Static base constructor
                        2.  Protected base constructor (StackOverflow !)
                        3.  Static base constructor, public field
                        4.  Protected base constructor, static field

                        Generics      Delegats & List
                        5.  Generic delegates, extension methods, List  
                
                        ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                Swap<Derived>();
                                break;

                            case 2:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                Swap<Derived_publ>();
                                break;

                            case 3:
                                Swap<Derived_public_field>();
                                Console.WriteLine("Create Derived from static base constructor ...");
                                break;

                            case 4:
                                Console.WriteLine("Create Derived from static base constructor ...");
                                var der_stat_field = Derived_static_field.Instance;
                                Console.WriteLine("");
                                break;

                            case 5:
                                Console.WriteLine("Create currying ...");
                                lists();
                                Console.WriteLine("");
                                break;

                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("Error");
                    }
                    finally
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Press Spacebar to exit; press any key to continue");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void Swap<T>() where T : new()
        {
            T puzzle = new T();
            Console.WriteLine("");
        }

        static void lists()
        {
            var source = new List<double> { 1.0, 2.4, 34.9, 9.02, 7.0 };
            var result = new List<double>();
            Func<double, double, double> f = (x, y) => x - y;


            var fBnd = f.Bnd()(2.0);

            Console.WriteLine("Source list");
            foreach (var item in source)
            {
                Console.Write("{0} ; ", item);
                result.Add(fBnd(item));
            }

            Console.WriteLine();
            Console.WriteLine("Result list");

            foreach (var item in result)
            {
                Console.WriteLine("{0} ; ", item);
            }
        }
    }
}