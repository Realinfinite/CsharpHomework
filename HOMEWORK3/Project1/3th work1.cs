using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IShape
    {
        // 接口成员
        double CalcuArea();
        bool TestShape();
    }



    //三角形
    class Triangle : IShape
    {
        private double a { set; get; }
       private double b { set; get; }
        private double c{ set; get; }
  
    public Triangle(double a1, double b1, double c1)
        {
            this.a = a1;
            this.b = b1;
            this.c = c1;
        }
        public double CalcuArea()
        {
            double d = (a + b + c) / 2.0;
            double s = Math.Sqrt(d * (d - a) * (d - b) * (d - c));
            return s;
        }
        public bool TestShape()
        {
        return ((a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (c + b) > a) ? true : false);
           
        }
    }
    //长方形
    class Rectangle : IShape
    {
        private  double a { set; get; }
    public double b { set; get; }
      
        public Rectangle(double a1, double b1)
        {
            this.a = a1;
            this.b = b1;
        }

        public bool TestShape()
        {
        return (a != b ? true : false);
          
        }
        public double CalcuArea()
        {
            double s = a * b;
            return s;
        }

    }
    //正方形
    class Square : IShape {
       public double a { get; set; }

        public Square(double a1)
        {
            this.a = a1;

        }
        public bool TestShape()
        {
            return true;
        }
        public double CalcuArea()
        {
            double s = a * a;
            return s;
        }
    }
    class Create
    {
        public void CreateTri()
        {

            string s1 = Console.ReadLine();
            double a = Convert.ToDouble(s1);
            string s2 = Console.ReadLine();
            double b = Convert.ToDouble(s2);
            string s3 = Console.ReadLine();
            double c = Convert.ToDouble(s3);
            Triangle tri = new Triangle(a, b, c);

            if (tri.TestShape())
            {
                Console.WriteLine("该图形的面积是" + tri.CalcuArea());
            }
            else
                Console.WriteLine("两边不合法，无法构造三角形");
        }
        public void CreateRec()
        {

            string s1 = Console.ReadLine();
            double a = Convert.ToDouble(s1);
            string s2 = Console.ReadLine();
            double b = Convert.ToDouble(s2);
            Rectangle rec = new Rectangle(a, b);
            if (rec.TestShape())
                Console.WriteLine("该图形的面积是" + rec.CalcuArea());

            else
                Console.WriteLine("两边不合法，无法构造长方形");
        }
        public void CreateSqu()
        {

            string s1 = Console.ReadLine();
            double a = Convert.ToDouble(s1);
            Square squ = new Square(a);
            Console.WriteLine("该图形的面积是" + squ.CalcuArea());
        }

    }
    class program
    {
        static void Main()
        {
            Create c = new Create();
            Console.WriteLine("输入三角形三边长");
            c.CreateTri();
            Console.WriteLine("输入长方形两边长");
            c.CreateRec();
            Console.WriteLine("输入正方形一边长");
            c.CreateSqu();
        }
    }



