using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 0;
            double y0 = 0;
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату х точки");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату у точки");
            double y = Convert.ToDouble(Console.ReadLine());
            double circumference = Circle.GetCircumference(r);
            double square = Circle.GetSquare(r);
            bool coordinates = Circle.GetCoordinates (x, y, r);
            Console.WriteLine("Длина окружности равна {0:f2}", circumference);
            Console.WriteLine("Площадь окружности равна {0:f2}", square);
            Console.WriteLine("Принадлежность точки: {0}", coordinates);
            Console.ReadKey();
        }
    }
}
