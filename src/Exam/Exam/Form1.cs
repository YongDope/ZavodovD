using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate(open.FileName);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Oprogramme op = new Oprogramme();
            op.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(X.Text);
            int y = Convert.ToInt32(Y.Text);

            if (x < 5 && x > -4 && y < 4 && y > -3)
            {
                Res.Text = "В области";
            }

            else
            {
                Res.Text = "Вне области";
            }
        } 
   }
}
