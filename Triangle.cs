using System; 
using System.Collections.Generic;
using System.Drawing;
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
        public double A // получить или узнать значения стороны треугольника
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public double H
        {
            get { return h; }
            set { h = value; }
        }

        /// <summary>
        /// Проверяет, существует ли треугольник или нет по формуле со сторонами.
        /// </summary>
        public bool ExistTriangle
        {
            get 
            {
                if ( (a < b + c) && (b < a + c) && (c < a + b) )
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
        public Triangle(double _a, double _b, double _c) // конструктор
        {
            a = _a;
            b = _b;
            c = _c;
            h = Height();
        }

        public Triangle(bool byHeight, double _a, double _h) // конструктор равнобедренного треугольника
        {
            if (byHeight == true)
            {
                a = _a;
                h = _h;
                b = _h;
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(h, 2));
            }
            else 
            {
                a = _a;
                h = _h;
                b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));
                c = b;
            }
        }

        public Triangle(bool byAngle, double _a, double _b, double angle) // конструктор с двумя сторонами и одним углом
        {
            if (byAngle)
            {
                a = _a;
                b = _b;
                c = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2) - (2 * a * b) * Math.Cos(ToRadians(angle)));
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
        
        /// <summary>
        /// Находит полупериметр по делению периметра на два.
        /// </summary>
        /// <returns>Полупериметр</returns>
        public double HalfPerimeter() // полупериметр
        {
            return Perimeter() / 2;
        }

        /// <summary>
        /// Нахождение площади по стандартной формуле.
        /// </summary>
        /// <returns>Вычисленную площадь.</returns>
        public double Surface() // площадь
        {
            double p = HalfPerimeter();
            double s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

        /// <summary>
        /// Вычисляет высоту по всем сторонам треугольника.
        /// </summary>
        /// <returns>Высоту треугольника.</returns>
        public double Height() // высота
        {
            double p = HalfPerimeter();
            double h = 2 * Math.Sqrt( p * (p - a) * (p - b) * (p - c) ) / a;
            return h;
        }

        /// <summary>
        /// Перевод градусов в радианы.
        /// </summary>
        /// <returns>Ввведённое значение в радианах.</returns>
        public static double ToRadians(double angle)
        {
            return angle * (Math.PI / 180);
        }

        public void DrawTriangle(Graphics field)
        {
            Pen p = new Pen(Brushes.Black, 2);
            var sinA = 2 * Surface() / (a * b);
            var alpha = Math.Asin(sinA);

            int x = Convert.ToInt32(b * Math.Cos(alpha));
            int y = Convert.ToInt32(b * Math.Sin(alpha));
            Point p1 = new Point(10, 90);
            Point p2 = new Point(10 + x, 90 - y);
            Point p3 = new Point(10 + Convert.ToInt32(a) , 90);

            Point[] points = new Point[] { p1, p2, p3 };
            field.DrawPolygon(p, points);
        }
    }
}
