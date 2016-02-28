using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._1
{
    class MyArray
    {
        int[] arr;

        public void Assign(int[] array1, int size)
        {
            try
            {
                try
                {
                    this.arr = new int[size];
                    for (int i = 0; i < array1.Length; i++)
                        this.arr[i] = array1[i] / array1[i + 1];

                    int[] int_array = new[] { 43, 90, 51 };
                    int_array[4] = 10;


                    unchecked
                    {
                        array1[3] = 1000000000 * 100;
                    }
                }

                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("It is IndexOutOfRangeException");
                }
                
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("It is DivideByZeroException");
                }

            }

            catch (NullReferenceException ex)
            {

            }
        }


        class CatchExceptionClass
        {
            public void CatchExceptionMethod()
            {
                try
                {
                    MyArray ma = new MyArray();



                    int[] arr = new int[4] { 1, 0, 8, 5 };

                    ma.Assign(arr, 4);
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.HelpLink);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.Source);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine( ex.TargetSite);
                }

                finally
                {
                    Console.WriteLine("block finally");
                }

            }

            class Program 
            {
                static void Main(string[] args)
                {
                    CatchExceptionClass cec = new CatchExceptionClass();
                    cec.CatchExceptionMethod();
                    Console.ReadKey();
                }
            
            }
           
        }
    }
}
