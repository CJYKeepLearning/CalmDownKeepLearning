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
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_Hong_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
                this.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked == true)
                this.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked == true)
                this.BackColor = Color.Blue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox1.Text + "、";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox2.Text + "、";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox3.Text + "、";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox4.Text + "、";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox5.Text + "、";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox6.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox6.Text + "、";
        }
    }
}
