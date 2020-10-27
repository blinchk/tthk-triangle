using System; 
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tthk_triangle
{
    /// <summary>
    /// Класс треугольника.
    /// </summary>
    class Triangle
    {
        
        // Поля треугольника
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

        /// <summary>
        /// Выводит тип треугольника в качестве его свойства.
        /// </summary>
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

        /// <summary>
        /// Конструктор равнобедреннонго треугольника.
        /// </summary>
        /// <param name="byHeight">Является ли треугольник прямоугольным?</param>
        /// <param name="_a">Сторона треугольника</param>
        /// <param name="_h">Высота треугольника</param>
        public Triangle(bool byHeight, double _a, double _h)
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
        
        /// <summary>
        /// Конструктор треугольника по углу и двум сторонам
        /// </summary>
        /// <param name="byAngle">Вызов правильного треугольника</param>
        /// <param name="_a">Первая сторона</param>
        /// <param name="_b">Вторая сторона</param>
        /// <param name="angle">Угол, прилежащий к первум двум сторонам</param>
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

        /// <summary>
        /// Вывод периметра треугольника.
        /// </summary>
        /// <returns>Периметр треугольника.</returns>
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

        /// <summary>
        /// Рисует треугольник по параметрам указанным в полях.
        /// </summary>
        /// <param name="field">Поле для рисования треугольника.</param>
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
