using System;
namespace Chapter8_2
{
    class Array
    {
        public int i;
        public double d;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Array[] arrays = new Array[20];
            for (int j = 0; j < arrays.Length; j++)
            {
                arrays[j] = new Array();
                arrays[j].i = j+1;
                arrays[j].d = Math.Sqrt(j+1);
            }
            FileStream fileStream = new FileStream("D:\\out.bin",FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fileStream);
            for (int k = 0;k < arrays.Length; k++)
            {
                bw.Write(arrays[k].i);
                bw.Write(arrays[k].d);
            }
            bw.Close();
            fileStream.Close();

            Console.WriteLine("请输入1-20之内的数字:");

            int num = Console.Read()-48;

            Console.WriteLine("对应的平方根为:");
            fileStream = new FileStream("D:\\out.bin", FileMode.Open, FileAccess.Read);
            //读二进制文件
            BinaryReader binaryReader = new BinaryReader(fileStream);
            for(int l = 1;l<=arrays.Length; l++)
            {
                int n = binaryReader.ReadInt32();
                if ( n.Equals(num))
                {
                    Console.WriteLine(arrays[l-1].d);
                    break;
                }else
                    binaryReader.ReadDouble();
            }
        }
    }
}