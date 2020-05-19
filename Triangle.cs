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
        public int color;

        // Свойства
        public double GetSetA
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

        public int GetSetColor
        {
            get { return color; }
            set { color = value;  }
        }

        public bool ExistTriange
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                    return false;
                else return true;
            }
        }

        // Методы
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
            color = 0;
        }

        public Triangle(double A, double B, double C, int Color)
        {
            a = A;
            b = B;
            c = C;
            color = Color;
        }

        public Triangle()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public string OutputA()
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

        public double Perimeter()
        {
            double p = a + b + c;
            return p;
        }
        
        public double HalfPerimeter()
        {
            return Perimeter() / 2;
        }

        public double Surface()
        {
            double p = HalfPerimeter();
            double s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }

        public double Height()
        {
            double p = HalfPerimeter();
            double h = 2 * Math.Sqrt( p * (p - a) * (p - b) * (p - c) ) / a;
            return h;
        }
    }
}
