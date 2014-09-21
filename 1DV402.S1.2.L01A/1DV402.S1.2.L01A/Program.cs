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


            int n1 = 1;

            int n2 = 2;

            int Raderhög = 25; // 25 rader skapar höjd i mönstret, kort sidan ska var 25 rader hög

            int raderbred = 39; // 29 kolumner skapar bred i mönstret, lång sidan ska vara 39 kolumner bred 

            int fergval = 1;

            for (int i = 0; i < Raderhög; i++) // bestämmer höjd i rader 
            {


                switch (fergval)// bestämmer vilken färg asterisken ska ha utifrån värdet inte variabel fergval har       
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

                for (int j = 0; j < raderbred; j++)// skriver ut 39 asterisk, som liger på bred
                {

                    Console.Write("*");
                    
                }
             
                Console.WriteLine();//Radbrytning

                n1++;

                if (n1 == n2) //gör så att vart annat asterisk rad är inskjuten ett steg  
                {

                Console.Write(" ");

                n2 = n2 + 2; 

                }

                

                
            }


            Console.ReadKey();// stanar programet och när man klickar på bokstav så avslutas den. 
            
        }
    }
}
