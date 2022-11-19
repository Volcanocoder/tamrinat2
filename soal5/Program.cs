using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nowmMojodi;
            int sod;
            int futureMojodi;

            Console.WriteLine("nowmMojodi-value: ");
            try
            {
                nowmMojodi = int.Parse(Console.ReadLine());
                Console.WriteLine("sod-value: ");
                sod = int.Parse(Console.ReadLine());
                Console.WriteLine("future-value: ");
                futureMojodi = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("********************************");
                Console.WriteLine(" ");
                getMojodi(futureMojodi, nowmMojodi, sod);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
        static double getMojodi(int futureMojodi, int nowMojodi, int sod)
        {
            double res = nowMojodi;
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine("mojodi bad as " + i.ToString() + " sal taghriban mishavad : ");
                res += res * (sod * 0.01);
                Console.WriteLine(((int)res).ToString());
                if (res > futureMojodi)
                {
                    break;
                }
            }
            return res;
        }
    }
}
