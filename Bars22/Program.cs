using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bars22
{
    class Square
    {
        public double a { get; set; }

        public Square(double _a)
        {
            this.a = _a;
        }

        public virtual double P()
        {
            return 4 * a;
        }

        public virtual double S()
        {
            return a * a;
        }

    }

    class Rectangle: Square
    {
        public double b { get; set; }

        public Rectangle(double _a, double _b): base(_a)
        {
            this.b = _b;
        }

        public override double P()
        {
            return  2*(a+b);
        }

        public override double S()
        {
            return a * b;
        }

    }

    class Circle
    {
        public double r { get; set; }

        public Circle(double _r)
        {
            this.r = _r;
        }

        public virtual double P()
        {
            return 2 * Math.PI * r;
        }

        public virtual double S()
        {

            return Math.PI * r * r;
        }

    }

    class Ellipse: Circle
    {
        public double r1 { get; set; }
        public Ellipse(double _r, double _r1): base(_r)
        {
            this.r1 = _r1;
        }

        public override double P()
        {
            return Math.PI * (r+r1);
        }

        public override double S()
        {

            return Math.PI * r * r1;
        }
    }

    class Triangle
    {

    }



    class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(3);
            Rectangle s2 = new Rectangle(1, 3);
            Square s3 = new Rectangle(1,3);

            Console.Write(s3.P());
            Console.Write("\n");
            Console.Write(s2.P());

        }
    }
}
