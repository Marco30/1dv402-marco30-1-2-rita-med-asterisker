using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1._2.L01A
{
    class Program
    {
        static void Main(string[] args)
        {

            string indata;
            Console.WriteLine("hej");
            Console.WriteLine("vad gör du");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" "); 
            Console.Write("* "); 
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" "); 
            Console.Write("* "); 
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ");
            Console.Write("* ");
            Console.WriteLine();

            int n1 = 1;
            int n2 = 2;
            int Raderhög = 25;
            int raderbred = 39;

            int test = 0;


            int fergval = 1;

            for (int i = 0; i < Raderhög; i++)
            {


                switch (fergval)
                {

                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            fergval = fergval + 1;
                            break;
                        }

                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            fergval = fergval + 1;
                            break;
                        }

                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            fergval = 1;
                            break;
                        }

                }

                for (int j = 0; j < raderbred; j++)
                {
                    Console.Write("*");
                    
                }

                Console.WriteLine();

                n1++;

                if(n1 == n2)
                {

                Console.Write(" ");

                n2 = n2 + 2; 

                }

                test++;

                
            }

            Console.WriteLine(test);
            indata = Console.ReadLine();
            
        }
    }
}
