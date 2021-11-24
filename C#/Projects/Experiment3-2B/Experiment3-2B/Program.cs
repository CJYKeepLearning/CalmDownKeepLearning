using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Experiment3_2B
{
    class Card
    {

        long cardNo;

        decimal balance;

        int currentNum;

        static int number;

        decimal[] currentMoney;

        int finite = 5000;

        string password = "123456";
        public Card()
        {
            currentMoney = new decimal[number];
        }
        public Card(long No, decimal Balance)
        {
            cardNo = No;

            balance = Balance;

            currentMoney = new decimal[number];
        }


        public void store(decimal Money, out int status)
        {
            if (finite - Math.Abs(Money) < 0)
            {
                status = -1;
                return;
            }
            else
            {
                finite = finite - (int)Math.Abs(Money);
            }
            if (currentNum == number)
            {
                status = 0; return;
            }
            if (balance + Money < 0)
            {
                status = -1; return;
            }
            currentMoney[currentNum] = Money;
            balance += Money;
            currentNum++;
            status = 1;
        }
        public void show()
        {

            Console.WriteLine("卡号: {0}， 当前余额: {1}， 当日发生业务的次数: {2}", cardNo, balance, currentNum);

            for (int i = 0; i < currentNum; i++)

                Console.WriteLine("当日存款/取款的情况: {0}", currentMoney[i]);
        }
        static public int Number
        {
            set
            {
                number = value;
            }
        }
        public long CardNo
        {
            get
            {
                return cardNo;
            }
        }
        public string PassWord
        {
            get { return password; }
        }
    }
    class Test3_2
    {
        static void Main(string[] args)
        {

            Test3_2 T = new Test3_2();
            Card[] person;
            int Num, status, k;
            long CardNo;
            decimal Balance, Money;
            Console.Write("请输入允许当日存款或取款的总次数: ");
            string sline = Console.ReadLine();
            Card.Number = int.Parse(sline);
            Console.Write("请输入某银行发出的储蓄卡总数: ");
            sline = Console.ReadLine();
            Num = int.Parse(sline);
            person = new Card[Num];
            for (int i = 0; i < Num; i++)
            {
                Console.Write("请输入卡号: ");
                sline = Console.ReadLine();
                CardNo = long.Parse(sline);

                Console.Write("请输入{0} 账户余额： ", CardNo);
                sline = Console.ReadLine();

                Balance = decimal.Parse(sline);

                person[i] = new Card(CardNo, Balance);
            }
            while (true)
            {

                Console.WriteLine("现在正进行存款取款的业务处理，如果输入的卡号<0,则结束业务处理");
                Console.Write("请输入卡号: ");

                sline = Console.ReadLine();

                CardNo = long.Parse(sline);
                if (CardNo < 0)

                    break;
                k = T.Locate(person, CardNo);

                if (k == -1)
                {
                    Console.WriteLine("对不起，不存在{0}号的储蓄卡", CardNo);
                    continue;
                }
                Console.WriteLine("请输入密码：");
                string tempPassword = string.Empty;
                ConsoleKeyInfo info;
                do
                {
                    info = Console.ReadKey(true);
                    if (info.Key != ConsoleKey.Enter && info.Key != ConsoleKey.Backspace && info.Key != ConsoleKey.Escape && info.Key != ConsoleKey.Tab && info.KeyChar != '\0')
                    {
                        tempPassword += info.KeyChar;
                        Console.Write('*');
                    }
                } while (info.Key != ConsoleKey.Enter);

                if (!tempPassword.Equals(person[k].PassWord))
                {
                    Console.WriteLine("密码错误！");
                }
                else
                {
                    Console.WriteLine("密码正确！");
                    Console.WriteLine("请输入卡金额(正值代表存款，复制代表取款)");
                    sline = Console.ReadLine();
                    Money = decimal.Parse(sline);
                    person[k].store(Money, out status);
                    switch (status)
                    {
                        case -2:
                            Console.WriteLine("进行存款/取款后超过每日使用最大金额（5000），不能进行取款/存款");
                            break;
                        case -1:
                            Console.WriteLine("存款余额不足，不能完成取款");
                            break;
                        case 0:
                            Console.WriteLine("本卡已达当日允许的业务次数");
                            break;
                        case 1:
                            Console.WriteLine("成功处理完当前业务");
                            person[k].show();
                            break;

                    }
                }
            }
        }
        int Locate(Card[] person, long cardNo)
        {
            for (int i = 0; i < person.Length; i++)
            {
                if (cardNo == person[i].CardNo)
                {
                    return i;
                }

            }
            return -1;
        }
    }
}
