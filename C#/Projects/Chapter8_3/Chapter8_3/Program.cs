// See https://aka.ms/new-console-template for more information
class CStudent
{
    public string name;
    public int id;
    public double chinese;
    public double english;
    public double math;
    public double ave;
    public bool Validate()
    {
        if(chinese>=0 && chinese<=100 && english>=0 && english<=100 && math>=0 && math <= 100)
        {
            return true;
        }
        return false;
    }
    public void Print()
    {
        Console.WriteLine("该生的姓名为:"+name+'\t'+"学号为:"+id+'\t'+"语文成绩为:"+chinese+'\t'+"英语成绩为:"+english+'\t'+"数学成绩为:"+math+'\t');
    }
}
class CStuFile{
    public FileStream fs = new FileStream("F:\\stu.txt", FileMode.Create);
    public LinkedList<CStudent> stus = new LinkedList<CStudent>();
    public void AddTo()
    {
        Console.Write("请输入学生信息:");
        CStudent student = new CStudent();
        Console.Write("请输入学生学号:");
        student.id = int.Parse(Console.ReadLine());
        student.name = Console.ReadLine();
        student.chinese = double.Parse(Console.ReadLine());
        student.english = double.Parse(Console.ReadLine());
        student.math = double.Parse(Console.ReadLine());
        student.ave = (student.chinese + student.math + student.english) / 3;
        stus.AddLast(student);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine(student.id+","+student.name+","+student.chinese+","+student.math+","+student.english+",");
    }
    public void List()
    {
        for (int i = 0; i < stus.Count; i++)
        {
            CStudent student = stus.ElementAt(i);
            Console.WriteLine("该生的姓名为:" + student.name + '\t' + "学号为:" + student.id + '\t' + "语文成绩为:" + student.chinese + '\t' + "数学成绩为:" + student.math + '\t' + "英语成绩为:" + student.english + '\t'+"平均分为:"+student.ave);
        }
    }
    public void Sort()
    {
        Console.WriteLine("按平均分排序:");
        CStudent[] s = new CStudent[stus.Count];
        for (int i=0; i < stus.Count; i++)
        {
            s[i] = stus.ElementAt(i);
        }
        CStudent cStudent = new CStudent();
        for (int i = 0; i < stus.Count; i++)
        {
            for (int j = 0; j < stus.Count - i - 1; j++)
            {
                if (s[j].ave > s[j+1].ave)
                { cStudent = s[j + 1]; s[j + 1] = s[j]; s[j] = cStudent; }
            }
        }
        for (int i = 0; i < s.Length; i++)
        {
            CStudent student = s[i];
            Console.WriteLine("该生的姓名为:" + student.name + '\t' + "学号为:" + student.id + '\t' + "语文成绩为:" + student.chinese + '\t' + "数学成绩为:" + student.math + '\t' + "英语成绩为:" + student.english + '\t' + "平均分为:" + student.ave);
        }
    }
    public void Seek(int id)
    {
        foreach (CStudent s in stus)
        {
            if (s.id == id)
            {
                Console.WriteLine("寻找到的学生信息为:" + s.name + '\t' + "学号为:" + s.id + '\t' + "语文成绩为:" + s.chinese + '\t' + "数学成绩为:" + s.math + '\t' + "英语成绩为:" + s.english + '\t' + "平均分为:" + s.ave);
            }
        }
    }
    public void Delete(int id)
    {
        foreach (CStudent s in stus)
        {
            if (s.id == id)
            {
                stus.Remove(s);            }
        }
        Console.WriteLine("删除完成");
    }
}
namespace Chapter8_3
{
    public class Chapter8_3
    {
        static void Main(string[] args)
        {
            CStuFile cStu = new CStuFile();
            if (File.Exists("F:\\stu.txt"))
            {
                FileStream file = new FileStream("F:\\stu.txt", FileMode.Open);
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    string txt = sr.ReadToEnd();
                    string[] arr = txt.Split(new char[] { '\u002C' });
                    for (int i = 0; i < arr.Length; i+=6)
                    {
                        CStudent student = new CStudent();
                        student.id = int.Parse(arr[i]);
                        student.name = arr[i+1];
                        student.chinese = double.Parse(arr[i+2]);
                        student.math = double.Parse(arr[i+3]);
                        student.english = double.Parse(arr[i + 4]);
                        student.ave = double.Parse(arr[i + 5]);
                        cStu.stus.AddLast(student);
                    }
                }
            }
            else
            {
                Console.WriteLine("输入学生信息的个数：");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    cStu.AddTo();
                }
            }
            Console.WriteLine("选择功能");
            Console.WriteLine("1:添加学生");
            Console.WriteLine("2:List展示学生");
            Console.WriteLine("3:查找学生");
            Console.WriteLine("4:删除学生");
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        cStu.AddTo();
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
                        Console.WriteLine("输入查询的id");
                        int id2 = int.Parse(Console.ReadLine());
                        cStu.Delete(id2);
                        break;
                }
            }
        }
    }
}