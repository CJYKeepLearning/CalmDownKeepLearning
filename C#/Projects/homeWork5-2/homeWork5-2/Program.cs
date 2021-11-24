using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homeWork5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int[] b = new int[str.Length];
            int k = 0;
            int f = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    f = 1;
                    b[k] = b[k] * 10 + str[i] - '0';
                }
                else if( f == 1 )
                {
                    k++;
                    f = 0;
                }
            }
            Console.WriteLine("一共有{0}个整数", k+1);
            for(int i = 0; i <=k; i++)
            {
                Console.Write("{0} ", b[i]);
            }
            /*10
            Console.WriteLine("请输入一组非零整数（输入0代表结束）：");
            int avg = 0;
            int n1 = 0, n2 = 0;
            int[] list = new int[100];
            int n = 1;
            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());
                avg += n;
                if (n > 0)  
                    n1++;
                if(n<0)
                    n2++;
            }
            avg = avg / (n1 + n2);
            Console.WriteLine("平均值：{0}\t正数有：{1}个\t负数有：{2}个", avg, n1, n2);
            */
            /*8
            int[] n = new int[10] {1,2,64,54,26,3,4,25,85,24};
            int max = 0;
            int index = maxIndex(n,out max);
            Console.Write("最大值的下标{0},最大值为{1}", index,max);

            /*6
            string sn = Console.ReadLine();
            int n = int.Parse(sn);
            String s = System.Convert.ToString(n, 16);
            Console.Write("{0}",s);
            */
            /*4
            Console.Write("请输入四位整数");
            string sn = Console.ReadLine();
            int n = int.Parse(sn);
            for(int i = 0; i < 4; i++)
            {
                int t = n % 10;
                Console.Write("{0}", t);
                n = n / 10;
            }
            */
            /*2
            Console.Write("请输入n的值");
            string sn = Console.ReadLine();
            int n = int.Parse(sn);
            float y = 0;
            float t = 1;
            for (int i = 1; i <= n; i++)
            {
                t = t * i;
                y = y + t;
            }
            Console.Write("y={0}", y);
            */

        }
        static int maxIndex(int[] a,out int max)
        {
            max = a[0];
            int index = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
