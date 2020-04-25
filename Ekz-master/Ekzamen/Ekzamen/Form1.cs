using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekzamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            txtSurename.Visible = false;
            txtName.Visible = false;
            txtGroup.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            btnSave.Visible = false;
            btnFill.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string[] Plane = new string[RazmerMassiva];
            if (txtName.Text != "" && txtSurename.Text != "" && txtGroup.Text != "")
            {
                Student pl = new Student();
                pl.Name = txtName.Text;
                pl.Surename = txtSurename.Text;
                pl.Group = txtGroup.Text;
                pl.Save();
                FillData();
            }
            else { MessageBox.Show("Все поля обязательны к заполнению!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void FillData()
        {
            dataGridView1.DataSource = WorkFile.ReadTable();
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPath.Text = ofd.FileName;
                    WorkFile.FilePath = ofd.FileName;
                    txtSurename.Visible = true;
                    txtName.Visible = true;
                    txtGroup.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    btnSave.Visible = true;
                    btnFill.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Формат не соответсвует требуемому.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
