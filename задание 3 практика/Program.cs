using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3_практика
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            int x;
            bool ok = false;

            do
            {
                Console.WriteLine("Введите х");
                string user = Console.ReadLine();
                ok = int.TryParse(user, out x);
                if (!ok) Console.WriteLine("Неверный ввод");
            }
            while (!ok);

            if (x > 0) y = -x * x;
            else y = -x;

            Console.WriteLine("y=" + y);
            Console.ReadKey();

        }
    }
}
