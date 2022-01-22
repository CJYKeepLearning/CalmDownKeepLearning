using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter8_1
{
    class Point
    {
        public int X;
        public int Y;
        public Point() { }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        //   cout<<    cin>>
        public static Point operator <<(Point x, int y)
        {
            Point point = new Point(x.X, x.Y);
            point.save();
            return new Point(x.X, x.Y);
        }
        public static Point operator >>(Point x, int y)
        {
            Console.WriteLine("(" + Convert.ToString(x.X) + "," + Convert.ToString(x.Y) + ")");
            return new Point();
        }

        public void save()
        {
            if (File.Exists("F:\\out.txt"))
            {
                File.AppendAllText("F:\\out.txt",
                    "(" + Convert.ToString(this.X) + "," + Convert.ToString(this.Y) + ")");
            }else
            {
                FileStream fileStream = new FileStream("F:\\out.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fileStream);
                sw.WriteLine("(" + Convert.ToString(this.X) + "," + Convert.ToString(this.Y) + ")");
                sw.Flush();
                sw.Close();
                fileStream.Close();
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入：");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Point point1 = new Point(x, y);
            Point point = point1 >> 1;
            Point point2 = point << 1;
            Console.ReadLine();
        }
    }
}