using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d ,year, month, week, day;
            Console.Write("tedad rooz ra vared konid :");
            a = Convert.ToInt32(Console.ReadLine());

            year = a / 365;
            b = a % 365;
            month = b / 30;
            c = b % 30;
            week = c / 7;
            d = c % 7;
            day = d;


            Console.WriteLine("saal  ={0} ", year);
            Console.WriteLine("maah  = {0}", month);
            Console.WriteLine("hafte  = {0}", week);
            Console.WriteLine("rooz  = {0}", day);




            Console.ReadKey();

        }
    }
}
