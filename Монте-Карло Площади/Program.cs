using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите номер задачи: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                One();
            }
            else if (n == 2)
            {
                Two();
            }
            else if (n == 3)
            {
                Three();
            }
            else if (n == 4)
            {
                Four();
            }
            else if (n == 5)
            {
                Five();
            }
            else if (n == 6)
            {
                Six();
            }
            else if (n == 7)
            {
                Seven();
            }
            else if (n == 8)
            {
                Eight();
            }
            
        }
        static void One()
        {
            Console.WriteLine("Метод Монте-Карло");
            Random random = new Random();
            double n = 10000000, k = 0;
            double s, x, y;
            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble();
                y = random.NextDouble();
                if (x * x + y * y <= 1)
                {
                    k = k + 1;
                }
            }
            s = 4 * (k / n);
            Console.WriteLine("Результат pi = " + s);
            Console.WriteLine("Точное pi = " + Math.PI);
        }
        static void Two()
        {
            Console.WriteLine("Метод Монте-Карло");
            Random random = new Random(3);
            double n = 1000000, k = 0;
            double s, x, y, a = 10, b = 10;
            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble() * 10;
                y = random.NextDouble() * 10;
                if (((x / 3) < y) && (y < ((x * (10 - x)) / 5)))
                {
                    k = k + 1;
                }
            }
            s = (k / n) * (a * b);
            Console.WriteLine("Результат pi = " + s);
        }
        static void Three()
        {
            Console.WriteLine("Метод Монте-Карло");
            Random random = new Random(3);
            double n = 1000000, k = 0;
            double s, x, y, a = 1, b = 20;
            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble() * 20 - 5;
                y = random.NextDouble();
  
                if ((y < Math.Sin(x)) && (y > 0))
                {
                    k = k + 1;
                }
            }
            s = (k / n) * (a * b);
            Console.WriteLine("Результат pi = " + s);
        }
        static void Four()
        {
            Console.WriteLine("Метод Монте-Карло");
            Random random = new Random(3);
            double n = 1000000, k = 0;
            double s, x, y, a = 10, b = 10;
            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble() * b;
                y = random.NextDouble() * a;
                if ((y < (x * (8 - x)) / 2) && (y > (x / 2)))
                {
                    k = k + 1;
                }
            }
            s = (k / n) * (a * b);
            Console.WriteLine("Результат pi = " + s);
        }
        static void Five()
        {
            Console.WriteLine("Метод Монте-Карло");
            Random random = new Random(3);
            double n = 1000000, k = 0;
            double s, x, y, a = 6, b = 15;
            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble() * b;
                y = random.NextDouble() * a;
                if ((y < 6) && (y > ((x - 6) * (x - 6)) / 6))
                {
                    k = k + 1;
                }
            }
            s = (k / n) * (a * b);
            Console.WriteLine("Результат pi = " + s);
        }
        static void Six()
        {
            Console.WriteLine("Метод Монте-Карло");
            Random random = new Random(3);
            double n = 1000000, k = 0;
            double s, x, y, a = 4, b = 10;
            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble() * b;
                y = random.NextDouble() * a;
                if ((y < ((x * (12 - x)) / 9) && (y > (x / 5))))
                {
                    k = k + 1;
                }
            }
            s = (k / n) * (a * b);
            Console.WriteLine("Результат pi = " + s);
        }
        static void Seven()
        {
            Console.WriteLine("Метод Монте-Карло");
            Random random = new Random(3);
            double n = 1000000, k = 0;
            double s, x, y, a = 4, b = 8;
            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble() * b;
                y = random.NextDouble() * a;
                if ((y < ((x * (8 - x)) / 4) && (y > (8 - x) / 8)))
                {
                    k = k + 1;
                }
            }
            s = (k / n) * (a * b);
            Console.WriteLine("Результат pi = " + s);
        }
        static void Eight()
        {
            Console.WriteLine("Метод Монте-Карло");
            Random random = new Random(3);
            double n = 1000000, k = 0;
            double s, x, y, a = 1, b = 3;
            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble() * b;
                y = random.NextDouble();
                if ((y < Math.Sin(x)) && (y > ((x - 2) * (x - 2)) / 2))
                {
                    k = k + 1;
                }
            }
            s = (k / n) * (a * b);
            Console.WriteLine("Результат pi = " + s);
        }
    }
}

