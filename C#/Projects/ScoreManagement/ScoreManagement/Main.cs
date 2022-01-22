using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm();
            modifyForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm();
            scoreForm.ShowDialog();
        }
    }
}
