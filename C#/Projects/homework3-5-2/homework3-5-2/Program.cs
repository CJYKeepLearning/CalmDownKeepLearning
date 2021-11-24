using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework3_5_2

{
    class CPoint
    {
        private double x;//坐标x轴的值
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        private double y;//坐标y轴的值
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public CPoint()
        {
            this.X = 0;
            this.Y = 0;
        }
        public CPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    class Cline : CPoint
    {
        private CPoint a = new CPoint();
        public CPoint A
        {
            get { return a; }
            set { a = value; }
        }
        private CPoint b = new CPoint();
        public CPoint B
        {
            get { return b; }
            set { b = value; }
        }
        public Cline(double a1, double a2, double b1, double b2)
        {
            A.X = a1; A.Y = a2;
            B.X = b1;B.Y = b2;
        }
        public double GetLength()
        {
            double m = A.X - B.X;
            double n = A.Y - B.Y;
            return Math.Sqrt(Math.Pow(m, 2) + Math.Pow(n, 2));
        }
    }
    class Crect : CPoint
    {
        private CPoint a = new CPoint();
        public CPoint A
        {
            get { return a; }
            set { a = value; }
        }
        private CPoint b = new CPoint();
        public CPoint B
        {
            get { return b; }
            set { b = value; }
        }
        public Crect(double a1, double a2, double b1, double b2)
        {
            A.X = a1;A.Y = a2;
            B.X = b1;B.Y = b2;
        }
        public double GetLength()
        {
            double m = Math.Abs(A.X - B.X);
            double n = Math.Abs(A.Y - B.Y);
            return 2.0 * (m + n);
        }
        public double GetArea()
        {
            double m = Math.Abs(A.X - B.X);
            double n = Math.Abs(A.Y - B.Y);
            return m * n;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            CPoint p = new CPoint(5, 10);
            Console.WriteLine("测试程序:");
            Console.WriteLine("该点坐标为:{0},{1}", p.X, p.Y);
            Cline l = new Cline(2, 5, 3, 8);
            Console.WriteLine("所得直线长度为 {0}", l.GetLength());
            Crect crect = new Crect(2, 3, 6, 4);
            Console.WriteLine("矩形周长为 ：{0},面积为 ：{1}", crect.GetLength(), crect.GetArea());
            Console.ReadLine();
        }
    }
}