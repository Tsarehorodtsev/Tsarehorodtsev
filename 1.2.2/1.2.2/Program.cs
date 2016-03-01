using _1._2._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._2
{

    class Box
    {
        public int position_x { get; set;}
        public int position_y {get; set;}
        public int width { get; set;}
        public int height { get; set;}
        public string message { get; set;}
        public char drawing_symbol { get; set; }

        public void Draw()
        {
            
               

                string mess_loc = message;

                int new_index = mess_loc.Length;
                new_index = (int)Math.Min(height - 2, new_index);
                

                if ((width >= 3) | (height >= 3))
                {
                    mess_loc = mess_loc.Substring(0, Math.Max(0,new_index));
                }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(position_x + (width - message.Length) / 2, position_y + height / 2);
            Console.Write(message);
            Console.SetCursorPosition(position_x, position_y);

            for (int i = 0; i <= height - 1; i++)
            {
                for (int j = 0; j <= width - 1; j++)
                {

                    if (i % (height - 1) == 0 || j % (width - 1) == 0)
                    {
                        Console.SetCursorPosition(position_x + j, position_y + i);
                        Console.Write(drawing_symbol);
                    }
                }
            }

         }
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Box features = new Box();

            Console.WriteLine("Enter coordinate X ");
            features.position_x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinate Y ");
            features.position_y = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Box's width");
            features.width = int.Parse(Console.ReadLine());

            Console.WriteLine("Box's heigth");
            features.height = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Type synbol of drawing: * , + ,  - ");
            features.drawing_symbol = char.Parse(Console.ReadLine());
            
            
            switch (features.drawing_symbol) 
            { 
                case '*' :
                    features.drawing_symbol = '*';
                    break;
                case '+' :
                    features.drawing_symbol = '+';
                    break;
                case '-' :
                    features.drawing_symbol = '-';
                    break;
                default :
                    Console.WriteLine("Please, type symbol from list");
                    break;
            }

            Console.WriteLine("Type  the message :  ");
            features.message = Console.ReadLine();

            features.Draw();
            
            Console.ReadLine();
       }
}
