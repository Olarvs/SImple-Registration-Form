using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPrint_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            txtPrint.Visible = true;

            prForm.Visible = true;
            prSec.Visible = true;
            prEmail.Visible = true;
            prName.Visible = true;
            prNum.Visible = true;

            outName.Visible = true;
            outName.Text = txtStudentName.Text;
            
            outSec.Visible = true;
            outSec.Text = txtCourse.Text +" "+ txtSection.Text;

            outNum.Visible = true;
            outNum.Text = txtNumber.Text;

            outEmail.Visible = true;
            outEmail.Text = txtEmail.Text;

            outTuition.Visible = true;
            prRemarks.Visible = true;

        }

        private void prForm_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outTuition.Visible = true;
            outTuition.Text = "Paid Tuition Fee";
            outTuition.ForeColor = Color.Black;

            btnPayment.Text = "Paid";
            btnPayment.BackColor = Color.Green;
            btnPayment.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void outTuition_Click(object sender, EventArgs e)
        {

        }
    }
}
