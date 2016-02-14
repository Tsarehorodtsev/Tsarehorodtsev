using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    class Program
    {
        static void Main(string[] args)
        {
         // 1) bool boo = 1;  булевой переменной присваивать можно только true или false
          //  char ch = 100; тип может объявлен только одному символу
           // byte ch;  переменная уже объявлена
           // sbyte sb = 250.7; слишком большое значение
          //  short sh = 150;
          //  ushort ush = 10000;
          //  int i = -25;
          // // uint ui = -223; не может быть отрицательным
          //  long l = 300;
          //// ulong ul = 100000.6; только целые
          //  decimal de = 8;
           // float fl = -33.1; не может быть отрицательным
           // double do;  do является ключевым словом , использовать как имя переменной нельзя


          //3) 
            var a1 = 20.5;
            var a2 = 20;
         //4)
          //  System.Int32 = -25;
          // System.Double = 0;
            if (true)
            {
                // 5)  int i;
                // char ch; 
                // double do;  переменные уже определены
               
                
              

                // 6) 
                bool boo = true;
            char ch = 'h' ;
         
            sbyte sb = 1;
            short sh = 150;
           ushort ush = 10000;
            int i = 25;
            uint ui = 223; 
            long l = 300;
           ulong ul = 100000; 
            decimal de = 8;
            float fl = 33.1F;

                // 8) 
                // int -> char
            int p = 5;
            char ic = (char)p;
                // bool -> short
                // невозможно
                // double -> long
            double d = 20.7;
            long lo = (long)d;
                // float -> char 
            float flo = 87.90F;
            char cha = (char)flo;
                // decimal -> double
            decimal decim = 53.22M;
            double t = (double)decim; 

                // byte -> uint
            byte q = 3;
            uint m = q;
                // ulong -> sbyte
            ulong re = 1000;
            sbyte pl = (sbyte)re;
            }

            //10)
            System.Nullable<int> tr;
            tr = null;
         //   int rt = null; инициализировать невозможно

        }
    }
}
