using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tthk_triangle
{
    class Triangle
    {
        
        // Поля
        public double a;
        public double b;
        public double c;
        public double outline;
        

        // Свойства
        public double GetSetA // получить или узнать значения стороны треугольника
        {
            get { return a; }
            set { a = value; }
        }

        public double GetSetB
        {
            get { return b; }
            set { b = value; }
        }

        public double GetSetC 
        {
            get { return c; }
            set { c = value; }
        }

        public bool ExistTriangle // существует ли треугольник
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                    return true;
                else return false;
            }
        }

        public string TriangleType
        {
            get
            {
                if (a == b && b == c && c == a)
                {
                    return "Равносторонний";
                }
                else if (b == c || a == b || c == a)
                {
                    return "Равнобедренный";
                }
                else return "Разносторонний";
            }
        }


        // Конструкторы
        public Triangle(double A, double B, double C) // конструктор
        {
            a = A;
            b = B;
            c = C;
            outline = 1;
        }

        public Triangle(double A, double B, double C, double _outline) // конструктор с линиями по краям
        {
            a = A;
            b = B;
            c = C;
            outline = _outline;
        }

        public Triangle() // конструктор без атрибутов
        {
            a = 0;
            b = 0;
            c = 0;
        }

        // Методы
        public string OutputA() // вывод сторон
        {
            return Convert.ToString(a);
        }

        public string OutputB()
        {
            return Convert.ToString(b);
        }

        public string OutputC()
        {
            return Convert.ToString(c);
        }

        public double Perimeter() // периметр
        {
            double p = a + b + c;
            return p;
        }
        
        public double HalfPerimeter() // полупериметр
        {
            return Perimeter() / 2;
        }

        public double Surface() // площадь
        {
            double p = HalfPerimeter();
            double s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

        public double Height() // высота
        {
            double p = HalfPerimeter();
            double h = 2 * Math.Sqrt( p * (p - a) * (p - b) * (p - c) ) / a;
            return h;
        }
    }
}
