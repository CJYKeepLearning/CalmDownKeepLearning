using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc[0] = "CJY";
            mc[1] = "ABC";
            Console.Write("{0}", mc[1]);
        }
    }
    class MyClass
    {
        private string[] data = new string[5];
        public string this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}
