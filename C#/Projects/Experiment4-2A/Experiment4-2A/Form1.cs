using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiment4_2A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm MDIChild = new MyForm();
            MDIChild.MdiParent = this;              // 设置子窗体的父窗体
            MDIChild.Show();					// 创建并显示一个子窗体
        }
    }
}
