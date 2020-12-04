using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Triangles
    {
        public class Triangle
        {
            public double a, b, c = 0;
            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                list.Add(this);
            }
        }

        double Ploshad(double a, double b, double c)
        {
            double poluPerimetr = (a + b + c) / 2;
            return Math.Sqrt(poluPerimetr*(poluPerimetr-a)* (poluPerimetr - b)* (poluPerimetr - c));
        }

        double Perimetr(double a, double b, double c)
        {
            return a + b + c;
        }

        static List<Triangle> list = new List<Triangle>();

        string Type(double a, double b, double c)
        {
            if (Math.Pow(c, 2) != Math.Pow(a, 2) + Math.Pow(b, 2)) return (Math.Pow(c, 2) < Math.Pow(a, 2) + Math.Pow(b, 2)) ? "Острый" : "Тупой";
            else return "Прямоугольный";
        }

        void trianglesCount()
        {
            int ostr = 0;
            int pryam = 0;
            int tup = 0;
            string res = "";
            foreach (Triangle triangle in list)
            {
                string type = Type(triangle.a, triangle.b, triangle.c);
                switch (type)
                {
                    case "Прямоугольный":
                        {
                            pryam++;
                            break;
                        }
                    case "Острый":
                        {
                            ostr++;
                            break;
                        }
                    case "Тупой":
                        {
                            tup++;
                            break;
                        }
                }
            }
            System.Windows.MessageBox.Show($"Острых {ostr}, прямоугольных {pryam}, {tup}");
        }
    }
}
