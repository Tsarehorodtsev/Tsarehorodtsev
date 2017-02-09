using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4._1
{

    class GoodsInfoEventArgs : EventArgs
    {
        public string GoodsName { get; private set;}

        public GoodsInfoEventArgs(string g_name) 
        {
            GoodsName = g_name;
        } 
    }

    class OnlineShop
    {
        public event EventHandler<GoodsInfoEventArgs> online_shop;
        
        public void NewGoods(string GoodsName)
        {

            if (online_shop != null) 
            {
                online_shop(this, new GoodsInfoEventArgs(GoodsName));
            }
        }
    }

    class Customer 
    {
        private string name { get; set; }

        public Customer()
        {
        }

        public Customer(string c_name) 
        {
            name = c_name;
        }

       
       
        public void GotNewGoods(object sender, GoodsInfoEventArgs e) 
        {
            Console.WriteLine("We have got new goods!!!");   
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            OnlineShop shop = new OnlineShop();

            Customer custom1 = new Customer("Ivan");
            shop.online_shop += custom1.GotNewGoods;

            Customer custom2 = new Customer("Serj");
            shop.online_shop += custom2.GotNewGoods;

            Customer custom3 = new Customer("John");
            shop.online_shop += custom3.GotNewGoods;

            shop.NewGoods("Some new goods");
            Console.ReadKey();
        }
    }
}


//2 типа, 2 класса . один наследуется от другого.
//+ интерфейс . перент класс имлементирует интерфейс ковариантный , и еще 1 контравариантный
// тоже самое с делегатами