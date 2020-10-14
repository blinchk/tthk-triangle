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
        public double h;
        

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

        public double GetSetH
        {
            get { return h; }
            set { h = value; }
        }

        public bool ExistTriangle // существует ли треугольник
        {
            get 
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                    return true;
                return false;
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
                return "Разносторонний";
            }
        }


        // Конструкторы
        public Triangle(double A, double B, double C) // конструктор
        {
            a = A;
            b = B;
            c = C;
            h = Height();
        }

        public Triangle(bool byHeight, double A, double H) // конструктор равнобедренного треугольника
        {
            if (byHeight == true)
            {
                a = A;
                h = H;
                b = h;
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(h, 2));
            }
            else 
            {
                a = A;
                h = H;
                b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));
                c = b;
            }
        }

        public Triangle(bool byAngle, double A, double B, double angle) // конструктор с двумя сторонами и одним углом
        {
            if (byAngle)
            {
                a = A;
                b = B;
                c = Math.Sqrt( Math.Pow(A, 2) + Math.Pow(B, 2) - (2 * A * B) * Math.Cos(angle) );
                h = Height();
            }
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

        public string OutputH()
        {
            return Convert.ToString(h);
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
