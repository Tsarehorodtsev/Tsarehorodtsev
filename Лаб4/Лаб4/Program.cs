using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб4
{
/*Desktop: CPU - 4 cores, 2,5 HGz, memory - 6 GB, HDD – 500 GB
Laptop: CPU - 2 cores, 1,7 HGz, memory - 4 GB, HDD – 250 GB
Server: CPU - 8 cores, 3 HGz, memory - 16 GB, HDD – 2 TB
    */
    class Program
    {
        struct Computer
        {
            public int CPU;
            public double speed;
            public int memory;
            public int HDD;
            public ComputerType computers;
        }
        enum ComputerType { Desktop, Laptop, Server };

        static void Main(string[] args)
        {

            Console.WriteLine("Managing computers in organization");
            Console.WriteLine();

            Computer desktop1 = new Computer();
            desktop1.CPU = 4;
            desktop1.speed = 2.5;
            desktop1.memory = 6;
            desktop1.HDD = 500;
            desktop1.computers = ComputerType.Desktop;

            Computer laptop1 = new Computer();
            laptop1.CPU = 2;
            laptop1.speed = 1.7;
            laptop1.memory = 4;
            laptop1.HDD = 250;
            laptop1.computers = ComputerType.Desktop;

            Computer server1 = new Computer();
            server1.CPU = 8;
            server1.speed = 3.0;
            server1.memory = 16;
            server1.HDD = 2000;
            server1.computers = ComputerType.Desktop;

            //RV: The array should contai computers, not integers (Computer[][]). What if you want to upgarade the amount of memory in just one of the computers in certain department? 
            int[][] departments = new int[4][];
            departments[0] = new int[3] { 2, 2, 1 };
            departments[1] = new int[3] { 0, 3, 0 };
            departments[2] = new int[3] { 3, 2, 0 };
            departments[3] = new int[3] { 1, 1, 2 };

            int i = 0;
            int countTypeDesktop = 0;
            int countTypeLaptop = 0;
            int countTypeServer = 0;
            int SumCount;

            for (i = 0; i < departments.Length; i++)
            {
                countTypeDesktop = countTypeDesktop + departments[i][0];
                countTypeLaptop = countTypeLaptop + departments[i][1];
                countTypeServer = countTypeServer + departments[i][2];
            }

            SumCount = countTypeDesktop + countTypeLaptop + countTypeServer;

            Console.WriteLine("Count of Desktop " + countTypeDesktop);
            Console.WriteLine("Count of Laptop " + countTypeLaptop);
            Console.WriteLine("Count of Server " + countTypeServer);
            Console.WriteLine("Count of computers " + SumCount);
            

            int max_HDD;
            int min_CPU;

            //RV: For finding the largest HDD delare the variable, say, int largestHDD = 0, go through the array of the computers 
            //RV: and computer's HDD is larger than largestHDD assign its HDD size to largestHDD.
            // Max HDD
            if ((desktop1.HDD > laptop1.HDD) && (desktop1.HDD > server1.HDD)) 
            {
                max_HDD = desktop1.HDD;
                Console.WriteLine("\nMax size HDD :  desktop1 " + max_HDD + "GB");
            }
            else if ((laptop1.HDD > desktop1.HDD) && (laptop1.HDD > server1.HDD)) 
            {
                max_HDD = laptop1.HDD;
                Console.WriteLine("\nMax size HDD : laptop1 " + max_HDD + "GB");
            }
            else if ((server1.HDD > laptop1.HDD) && (server1.HDD > desktop1.HDD)) 
            {
                max_HDD = server1.HDD;
                Console.WriteLine("\nMax size HDD : server1 " + max_HDD + "GB");
            }
            
            
            
            
            //RV: The same as above
            //Min CPU
            if ((desktop1.CPU < laptop1.CPU) && (desktop1.CPU < server1.CPU))
            {
                min_CPU = desktop1.CPU;
                Console.WriteLine("\nMin number of CPU :  desktop1 " + min_CPU + "cores");
            }
            else if ((laptop1.CPU < desktop1.CPU) && (laptop1.CPU < server1.CPU))
            {
                min_CPU = laptop1.CPU;
                Console.WriteLine("\nMin number of CPU : laptop1 " + min_CPU + "cores");
            }
            else if ((server1.CPU < laptop1.CPU) && (server1.CPU < desktop1.CPU))
            {
                min_CPU = server1.CPU;
                Console.WriteLine("\nMin number of CPU : server1 " + min_CPU + "cores");
            }

            //RV: Why do you increasing the memory one by one? You can just assign 8;
            do
            {
                desktop1.memory = desktop1.memory + 1;
            }
            while (desktop1.memory != 8);
            Console.WriteLine("\nChecking update of desktop memory " + desktop1.memory + "GB");

            Console.ReadKey();
        }
    }
}
