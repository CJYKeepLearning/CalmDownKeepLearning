using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX7_12
{
    
    public partial class Form1 : Form
    {
        Graphics g;
        Point pStart, pEnd;
        int ChoiceGraph;
        int penWidth;
        enum mySelected
        {
            Pencil,
            Line,
            Ellipse,
            FillEllipse,
            Rec,
            FillRec,
            Eraser
        }
        public Form1()
        {
            InitializeComponent();
        }
       
      
        
        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.pictureBox1.CreateGraphics();
            ChoiceGraph = (int)mySelected.Pencil;
            penWidth = 3;
            btnControl.BackColor = btnBlack.BackColor;
        }

        private void btnpencil_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnline_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnFillEllipse_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnFillRec_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }
       

        private void btnLine1_Click(object sender, EventArgs e)
        {
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;
            penWidth = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnLine2_Click(object sender, EventArgs e)
        {
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;
            penWidth = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnLine3_Click(object sender, EventArgs e)
        {
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;
            penWidth = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnLine4_Click(object sender, EventArgs e)
        {
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;
            penWidth = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnLine5_Click(object sender, EventArgs e)
        {
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;
            penWidth = Convert.ToInt32(((Button)sender).Tag);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {
                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {
                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {
                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {
                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {
                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {
                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {
                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void Change_Point()
        {
            Point pTemp = new Point();          // 定义临时点
            if (pStart.X < pEnd.X)
            {
                if (pStart.Y > pEnd.Y)
                {
                    pTemp.Y = pStart.Y;
                    pStart.Y = pEnd.Y;
                    pEnd.Y = pTemp.Y;
                }
            }
            if (pStart.X > pEnd.X)
            {
                if (pStart.Y < pEnd.Y)
                {
                    pTemp.X = pStart.X;
                    pStart.X = pEnd.X;
                    pEnd.X = pTemp.X;
                }
                if (pStart.Y > pEnd.Y)
                {
                    pTemp = pStart;
                    pStart = pEnd;
                    pEnd = pTemp;
                }
            }
        }
        private void pictureBox1_MouseDown(object sender,MouseEventArgs e)
        {
            if(e.Button ==MouseButtons.Left)
            {
                pStart.X = e.X;
                pStart.Y = e.Y; 
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "X:" + e.X.ToString() + ",Y:" + e.Y.ToString();

            if (e.Button == MouseButtons.Left)
            {
                switch (ChoiceGraph)
                {
                    case (int)mySelected.Pencil:            // 选择的是铅笔
                        Pen pen1 = new Pen(btnControl.BackColor, penWidth);
                        pEnd.X = e.X;
                        pEnd.Y = e.Y;
                        g.DrawLine(pen1, pStart, pEnd);
                        pStart = pEnd;                      // 将已经绘制的终点作为下一次绘制的起点
                        break;
                    case (int)mySelected.Eraser:
                        Pen pen2 = new Pen(Color.White, penWidth);      // 定义白色画笔作为擦除效果
                        pEnd.X = e.X;
                        pEnd.Y = e.Y;
                        g.DrawLine(pen2, pStart, pEnd);
                        pStart = pEnd;                  // 将已经绘制的终点作为下一次绘制的起点
                        break;
                    default:
                        break;
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)          // 如果用户按下的是鼠标左键，记录终点坐标
            {
                pEnd.X = e.X;
                pEnd.Y = e.Y;
                switch (ChoiceGraph)
                {
                    case (int)mySelected.Line:          // 如果选择的是直线
                        Pen pen1 = new Pen(btnControl.BackColor, penWidth);
                        g.DrawLine(pen1, pStart, pEnd);
                        break;
                    case (int)mySelected.Ellipse:       // 如果选择的是空心椭圆
                        Change_Point();
                        Pen pen2 = new Pen(btnControl.BackColor, penWidth);
                        g.DrawEllipse(pen2, pStart.X, pStart.Y, pEnd.X - pStart.X, pEnd.Y - pStart.Y);
                        break;
                    case (int)mySelected.FillEllipse:       // 如果选择的是实心椭圆
                        Change_Point();
                        SolidBrush myBrush1 = new SolidBrush(btnControl.BackColor);
                        Rectangle rec1 = new Rectangle(pStart.X, pStart.Y, pEnd.X - pStart.X
                                                                , pEnd.Y - pStart.Y);
                        g.FillEllipse(myBrush1, rec1);

                        break;
                    case (int)mySelected.Rec:           // 如果选择的是矩形
                        Change_Point();
                        Pen pen3 = new Pen(btnControl.BackColor, penWidth);
                        g.DrawRectangle(pen3, pStart.X, pStart.Y, pEnd.X - pStart.X, pEnd.Y - pStart.Y);
                        break;
                    case (int)mySelected.FillRec:       // 如果选择的是实心矩形
                        Change_Point();
                        SolidBrush myBrush2 = new SolidBrush(btnControl.BackColor);
                        Rectangle rec2 = new Rectangle(pStart.X, pStart.Y, pEnd.X - pStart.X
                                                                , pEnd.Y - pStart.Y);
                        g.FillRectangle(myBrush2, rec2);
                        break;
                    default:
                        break;
                }
            }
        }
        private void btnNew_Click(object sender,EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                pStart.X = e.X;
                pStart.Y = e.Y;
            }
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "X:" + e.X.ToString() + ",Y:" + e.Y.ToString();

            if (e.Button == MouseButtons.Left)
            {
                switch (ChoiceGraph)
                {
                    case (int)mySelected.Pencil:            // 选择的是铅笔
                        Pen pen1 = new Pen(btnControl.BackColor, penWidth);
                        pEnd.X = e.X;
                        pEnd.Y = e.Y;
                        g.DrawLine(pen1, pStart, pEnd);
                        pStart = pEnd;                      // 将已经绘制的终点作为下一次绘制的起点
                        break;
                    case (int)mySelected.Eraser:
                        Pen pen2 = new Pen(Color.White, penWidth);      // 定义白色画笔作为擦除效果
                        pEnd.X = e.X;
                        pEnd.Y = e.Y;
                        g.DrawLine(pen2, pStart, pEnd);
                        pStart = pEnd;                  // 将已经绘制的终点作为下一次绘制的起点
                        break;
                    default:
                        break;
                }
            }
            }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)          // 如果用户按下的是鼠标左键，记录终点坐标
            {
                pEnd.X = e.X;
                pEnd.Y = e.Y;
                switch (ChoiceGraph)
                {
                    case (int)mySelected.Line:          // 如果选择的是直线
                        Pen pen1 = new Pen(btnControl.BackColor, penWidth);
                        g.DrawLine(pen1, pStart, pEnd);
                        break;
                    case (int)mySelected.Ellipse:       // 如果选择的是空心椭圆
                        Change_Point();
                        Pen pen2 = new Pen(btnControl.BackColor, penWidth);
                        g.DrawEllipse(pen2, pStart.X, pStart.Y, pEnd.X - pStart.X, pEnd.Y - pStart.Y);
                        break;
                    case (int)mySelected.FillEllipse:       // 如果选择的是实心椭圆
                        Change_Point();
                        SolidBrush myBrush1 = new SolidBrush(btnControl.BackColor);
                        Rectangle rec1 = new Rectangle(pStart.X, pStart.Y, pEnd.X - pStart.X
                                                                , pEnd.Y - pStart.Y);
                        g.FillEllipse(myBrush1, rec1);

                        break;
                    case (int)mySelected.Rec:           // 如果选择的是矩形
                        Change_Point();
                        Pen pen3 = new Pen(btnControl.BackColor, penWidth);
                        g.DrawRectangle(pen3, pStart.X, pStart.Y, pEnd.X - pStart.X, pEnd.Y - pStart.Y);
                        break;
                    case (int)mySelected.FillRec:       // 如果选择的是实心矩形
                        Change_Point();
                        SolidBrush myBrush2 = new SolidBrush(btnControl.BackColor);
                        Rectangle rec2 = new Rectangle(pStart.X, pStart.Y, pEnd.X - pStart.X
                                                                , pEnd.Y - pStart.Y);
                        g.FillRectangle(myBrush2, rec2);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnExit_Click(object sender,EventArgs e)
        {
            this.Close();
        }

    }
}
