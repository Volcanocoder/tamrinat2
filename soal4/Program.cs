using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soal4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x-value: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("y-value: ");
            int y = int.Parse(Console.ReadLine());
            int bmm = 1;
            int temp;

            if (x > y)
            {
                temp = x;
                x = y;
                y = temp;
            }

            for (int i = 1; i < (x + 1); i++)
            {
                if (x % i == 0 && y % i == 0)
                    bmm = i;
            }

            Console.WriteLine("BMM of " + x + " va " + y + " is: " + bmm);

            int result = KMM(x, y);

            Console.WriteLine("KMM of {0} va {1} is {2}", x, y, result);
            Console.Read();
        }
        public static int KMM(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i < num2; i++)
            {
                int mult = num1 * i;
                if (mult % num2 == 0)
                {
                    return mult;
                }
            }
            return num1 * num2;
        }
    }
}
