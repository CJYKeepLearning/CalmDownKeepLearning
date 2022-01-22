using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class CStudent
    {
        public string name;
        public int id;
        public double cpp;
        public double english;
        public double math;
        public double ave;
        public bool Validate()
        {
            if (cpp >= 0 && cpp <= 100 && english >= 0 && english <= 100 && math >= 0 && math <= 100)
            {
                return true;
            }
            return false;
        }
        public CStudent() { }
        public CStudent(string name1, int id1, double cpp, double english, double math)
        {
            this.name = name1;
            this.id = id1;
            this.cpp = cpp;
            this.english = english;
            this.math = math;
            this.ave = (this.cpp + this.english + this.math) / 3;
        }
        public void save()
        {
            FileStream file = new FileStream("F:\\stu.txt",
               FileMode.Create);
            StreamWriter sw = new StreamWriter(file);
            sw.Write(name, id, cpp, english, math, ave);
            sw.Close();
            file.Close();

        }
        public void Print()
        {
            Console.WriteLine("该生的姓名为:" + name + '\t' + "学号为:" + id + '\t' + "cpp成绩为:" + cpp + '\t' + "英语成绩为:" + english + '\t' + "数学成绩为:" + math + '\t');
        }
    }
    class CStuFile
    {
        public int N;
        public CStudent[] s;
        public void AddTo(int n)
        {
            this.N = n;
            string name;
            int id;
            double cppgrade;
            double Egrade;
            double Mgrade;

            this.s = new CStudent[this.N];
            for (int i = 0; i < this.N; i++)
            {
                Console.WriteLine("\t"+"学生姓名：");
                name = Console.ReadLine();
                Console.WriteLine("\t" + "学生学号：");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\t" + "学生CPP成绩：");
                cppgrade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\t" + "学生英语成绩：");
                Egrade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\t" + "学生数学成绩：");
                Mgrade = Convert.ToDouble(Console.ReadLine());
                s[i] = new CStudent(name, id, cppgrade, Egrade, Mgrade);
                s[i].save();
            }

        }
        public void List()
        {
            for (int i = 0; i < s.Length; i++)
            {
                CStudent student = s.ElementAt(i);
                Console.WriteLine("该生的姓名为:" + student.name + '\t' + "学号为:" + student.id + '\t' + "CPP成绩为:" + student.cpp + '\t' + "数学成绩为:" + student.math + '\t' + "英语成绩为:" + student.english + '\t' + "平均分为:" + student.ave);
            }
        }
        public void sort()
        {
            CStudent temp = new CStudent();
            for (int i = 0; i < this.N - 1; i++)
            {
                for (int j = i + 1; j < this.N; j++)
                {
                    if (s[i].ave > s[j].ave)
                        temp = s[i];
                    s[i] = s[j];
                    s[j] = temp;
                }
            }
        }

        public void Seek(int id)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].id == id)
                {
                    s[i].Print();
                }
            }
        }

        public void Delete(int id)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].id == id)
                {
                    for (; i < s.Length - 1; i++)
                    {
                        s[i].name = s[i + 1].name;
                        s[i].id = s[i + 1].id;
                        s[i].cpp = s[i + 1].cpp;
                        s[i].english = s[i + 1].english;
                        s[i].math = s[i + 1].math;
                        s[i].ave = s[i + 1].ave;
                    }
                    Console.WriteLine("删除成功");
                    break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CStuFile cStu = new CStuFile();
            Console.WriteLine("选择功能");
            Console.WriteLine("1:添加学生");
            Console.WriteLine("2:List展示学生");
            Console.WriteLine("3:查找学生");
            Console.WriteLine("4:删除学生");
            while (true)
            {
                Console.WriteLine("输入选择的功能");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("输入学生数目：");
                        int n = Convert.ToInt32(Console.ReadLine());
                        cStu.AddTo(n);
                        break;
                    case 2:
                        cStu.List();
                        break;
                    case 3:
                        Console.WriteLine("输入查询的id");
                        int id1 = int.Parse(Console.ReadLine());
                        cStu.Seek(id1);
                        break;
                    case 4:
                        Console.WriteLine("输入删除的id");
                        int id2 = int.Parse(Console.ReadLine());
                        cStu.Delete(id2);
                        break;
                }
            }
        }
    }
}