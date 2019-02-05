using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcije
{
    class Program
    {
        static void name(string name)
        {
            Console.WriteLine(name);
        }


        static int plus(int n1, int n2)
        {
            int plus = n1 + n2;
            return plus;
        }


        static void Main(string[] args)
        {
            //name("Hashim");

            Console.WriteLine("your name?");
            string mm = Console.ReadLine();
            name(mm);

            //----------


            /*int number1 = 10;
            int number2 = 10;

            int o = plus(number1, number2);
            Console.WriteLine(o);*/

            Console.WriteLine("write any number");
            int number1 = Convert.ToInt16(Console.ReadLine());
            int number2 = Convert.ToInt16(Console.ReadLine());

            int o = plus(number1, number2);
            Console.WriteLine(o);


            Console.ReadKey();
        }
    }







}
