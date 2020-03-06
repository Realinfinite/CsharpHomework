using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

interface IShape {
    double CalcuArea();
    bool TestShape();

}

class Triangle : IShape
{
    private double a { set; get; }
    private double b { set; get; }
    private double c { set; get; }

    public Triangle(double a1, double b1, double c1)
    {
        try {
            this.a = a1;
            this.b = b1;
            this.c = c1;
        }

        catch (Exception ex)
        {
            Console.WriteLine("不合法");
        }
    
    }
    public double CalcuArea()
    {
      
            double d = (a + b + c) / 2.0;
            return (Math.Sqrt(d * (d - a) * (d - b) * (d - c)));
    
    }
    public bool TestShape()
    {
        return ((a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (c + b) > a) );

    }
    class Rectangle : IShape
    {
        private double a { set; get; }
        private double b { set; get; }

        public Rectangle(double a1, double b1)
        {
            try
            {
                this.a = a1;
                this.b = b1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("不合法");
            }
        }

        public bool TestShape()
        {
            return (a != b&&a>0&&b>0);
        }
        public double CalcuArea()
        {

            return (a * b);
        }

    }
    class Square : IShape
    {
        private double a { get; set; }

        public Square(double a1)
        {
            try
            {
                this.a = a1;
            }
            catch(Exception ex)
            {
                Console.WriteLine("不合法");
            }
        }
        public bool TestShape()
        {
            return (a > 0 );
        }
        public double CalcuArea()
        {
            return (a * a);
        }

    }
    class ShapeFactory
    {


        public double Selection(int n)
        {
            Random ra = new Random();
            bool flag = false;
            double s = 0;

            switch (n)
            {
                case 0:
                    while (!flag)
                    {
                        Triangle tri = new Triangle(ra.Next(1, 100), ra.Next(1, 100), ra.Next(1, 100));
                        s = tri.CalcuArea();
                        flag = tri.TestShape();
                    }
                    Console.WriteLine("随机构造三角形，其面积为" + Math.Round(s, 2));
                    break;
                case 1:
                    while (!flag)
                    {
                        Rectangle rec = new Rectangle(ra.Next(1, 100), ra.Next(1, 100));
                        s = rec.CalcuArea();
                        flag = rec.TestShape();
                    }
                    Console.WriteLine("随机构造矩形，其面积为" + Math.Round(s, 2));
                    break;
                case 2:
                    while (!flag)
                    {
                        Square squ = new Square(ra.Next(1, 100));
                        s = squ.CalcuArea();
                        flag = squ.TestShape();
                    }
                    Console.WriteLine("随机构造正方形，其面积为" + Math.Round(s, 2));
                    break;
                default:
                    break;
            }
            return (Math.Round(s, 2));
        }
    }
    class program
    {
        static void Main()
        {
            ShapeFactory shapefac = new ShapeFactory();
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Random ra = new Random();
                int n = ra.Next(1, 100);
                int m = n % 3;
                total += shapefac.Selection(m);
            }
            Console.WriteLine("随机构造图形的总面积为" + total);
        }
    }
}
