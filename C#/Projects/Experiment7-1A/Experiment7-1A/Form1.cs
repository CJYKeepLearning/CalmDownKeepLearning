using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment7_1A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建Graphic对象
            Graphics myGra = this.CreateGraphics();
            //画直线
            Pen myPen1 = new Pen(Color.Red, 2);
            myGra.DrawLine(myPen1, 100, 0, 300, 500);
            //画圆和椭圆
            Pen myPen2 = new Pen(Color.Orange, 2);
            myGra.DrawLine(myPen2, 100, 100, 60, 60);
            myGra.DrawLine(myPen2, 200, 100, 60, 120);
            //画矩形
            Pen myPen3 = new Pen(Color.Yellow, 3);
            myGra.DrawLine(myPen3, 123, 234, 60, 60);
            myGra.DrawLine(myPen3, 223, 234, 60, 120);
            //画自定义多边形
            Point[] myPoint = new Point[4];
            myPoint[0].Y = 100;
            myPoint[1].X = 300;
            myPoint[1].Y = 20;
            myPoint[2].X = 100;
            myPoint[2].Y = 430;
            myPoint[3].X = 100;
            myPoint[3].Y = 123;
            Pen myPen20 = new Pen(Color.Aqua);
            myGra.DrawPolygon(myPen20, myPoint);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics fontGra = this.CreateGraphics();
            Font myFont = new Font("楷体_GB2312", 24);
            Brush myBr = new SolidBrush(Color.Red);
            fontGra.DrawString(button2.Text, myFont, myBr, new Point(200, 200));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics clearG = this.CreateGraphics();
            clearG.Clear(Color.White);
        }
    }
}
