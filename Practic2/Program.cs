using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Optim();
            NotOptim();
            Console.ReadKey();
        }

        static double H, b, S, s,h,x;

        static void Optim()
        {
            Console.WriteLine("Оптимальное решение:\n");
            Console.WriteLine("Введите высоту треугольника");
            H = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите основание треугольника");
            b = double.Parse(Console.ReadLine());
            S = 0.5 * H * b; //Площадь треугольника
            s = S * 0.5; //По оптимальному решению, максимальная площадь параллелограмма равна половине площади треугольника
            Console.WriteLine("Максимальная площадь параллелограмма равна: " + s + "\n");
        }


        static void NotOptim()
        {
            Console.WriteLine("Неоптимальное решение:\n");
            Console.WriteLine("Введите высоту треугольника");
            H = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите основание треугольника");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту параллелограмма");
            h = double.Parse(Console.ReadLine());
            x = (H - h) / H * b; 
            s = x * h;
            Console.WriteLine("Максимальная площадь параллелограмма равна: "+s);
        }
    }
}
