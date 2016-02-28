using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._2
{
    class Bird
    {

        public int[] FlySpeed = { 5, 15, 25, 35 };
        public int NormalSpeed { get; set; }
        public string Nick { get; set; }

        private bool BirdFlewAway;

        public Bird() { }
        public Bird(string name, int speed)
        {
            NormalSpeed = speed;
            Nick = name;
        }

        public void FlyAway(int incrmnt)
        {
            if (BirdFlewAway)
                Console.WriteLine("{0} flew away ...", Nick);
            else
            {
                NormalSpeed += incrmnt;
                if (NormalSpeed >= FlySpeed[3])
                {
                    BirdFlewAway = true;
                    NormalSpeed = 0;

                    BirdFlewAwayException ex = new BirdFlewAwayException(string.Format("{0} flew with incredible speed!", Nick), "Oh! Startle.", DateTime.Now);
                    ex.HelpLink = "http://en.wikipedia.org/wiki/Tufted_titmouse";

                    throw ex;
                }
                else
                    Console.WriteLine("... flying close with the speed = {0}", NormalSpeed);
            }
        }
    }

    public class BirdFlewAwayException : ApplicationException
    {
        public DateTime When { get; set; }
        public string Why { get; set; }

        public BirdFlewAwayException() { }

        public BirdFlewAwayException(string message, string cause, DateTime time)
            : base(message)
        {
            Why = cause;
            When = time;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observation titmouse flight");
            Bird My_Bird = new Bird("Titmouse", 20);
            int ii;
            char rdk;
            try
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Monitoring in Try block ");
                        Console.WriteLine(@"Please, type the number
                1. array overflow
                2. throw exception
                3. user exception
                                    ");
                        uint i = uint.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                int j = My_Bird.FlySpeed[4];
                                break;
                            case 2:
                                throw (new System.Exception("Oh! My system exception..."));
                            case 3:
                                for (ii = 0; ii < My_Bird.FlySpeed[3]; ii++)
                                {
                                    My_Bird.FlyAway(ii);
                                }
                                break;
                            default:
                                break;
                        }



                    }
                    catch (BirdFlewAwayException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.When);
                        Console.WriteLine(e.Why);

                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("CLS exception: Message -  " + e.Message + " Source - " + e.Source);
                       
                    }
                    finally
                    {
                        Console.WriteLine("For next step ...");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    
                    rdk = Console.ReadKey().KeyChar;
                } while (rdk != ' ');

            }
            catch (Exception mn)
            {
                
            }


                 }

    }
}