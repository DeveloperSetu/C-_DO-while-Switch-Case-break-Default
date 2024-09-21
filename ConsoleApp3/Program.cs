using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Cache;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Day();
            Console.ReadKey();
        }

        public static void Day()
        {
            var aggre ="";
            do
            {
                Console.WriteLine(" Enter your Number 1-7 For See The Day ");
                int day = Convert.ToInt32(Console.ReadLine());
                var a = "";
                switch (day)
                {
                    case 1:
                        a = "SaturDay";
                        break;
                    case 2:
                        a = "SunDay";
                        break;
                    case 3:
                        a="Monday";
                        break;
                    case 4:
                        a = "Tuesday";
                        break;
                    case 5:
                        a="Wednessday";
                        break;
                    case 6:
                        a = "Thasday";
                        break;
                    default:
                        a="Friday";
                        break;
                }

                Console.WriteLine("Day Name: " + a);
                Console.WriteLine(" Do you Continue? Y/N");
                aggre = Console.ReadLine().ToUpper();

            }while( aggre == "Y");

        }
    }//internal Class..........


}//nameSpace
