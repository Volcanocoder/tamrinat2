using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal2
{
    class Program
    {
        static void Main()
        {
            int a;
            int b;
            int c;

            Console.Write("a : ");
            try
            {
                a = int.Parse(Console.ReadLine());
                Console.Write("b : ");
                b = int.Parse(Console.ReadLine());
                Console.Write("c : ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine(getRishe(a, b, c, true));
                Console.WriteLine(getRishe(a, b, c, false));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }

        static string getRishe(int a, int b, int c, bool isPositiv)
        {
            var delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return "rishe nadarad";
            }
            else
            {
                var sgn = isPositiv ? 1.0 : -1.0;
                string res = ((sgn * Math.Sqrt(delta) - b) / (2.0 * a)).ToString();
                return isPositiv ? "rishe mosbat : " + res : "rishe manfi: " + res;
            }
        }
    }
}
