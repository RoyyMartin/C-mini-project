using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ConverterT : Form
    {
        double result = 0.0; Boolean fahText=false;Boolean celText=false;

        public ConverterT()
        {
            InitializeComponent();
        }

        private void ConverterT_Load(object sender, EventArgs e)
        {
           
            txtCe.Enabled = false;
            txtF.Enabled = false;
        }
       

        private void btnCeToF_Click(object sender, EventArgs e)
        {
            if (txtF.Enabled == true)
            { MessageBox.Show("You cannot convert both at a time!!","Error"); }
            else txtCe.Enabled = true;
        }

        private void btnFToCe_Click(object sender, EventArgs e)
        {
            if (txtCe.Enabled == true)
            { MessageBox.Show("You cannot convert both at a time!!", "Error"); }
            else txtF.Enabled = true;
        }

       
        private void txtF_TextChanged(object sender, EventArgs e)
        {
            fahText = true;
        }

        private void txtCe_TextChanged(object sender, EventArgs e)
        {
            celText = true;
        }

        
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormulaTable f = new FormulaTable();
            f.Show();
            this.Hide();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (txtCe != null && celText==true)
            {
                var cel = Convert.ToDouble(txtCe.Text);
                result = (cel * 9 / 5) + 32;
                MessageBox.Show(cel + " 'C = " + result + " 'F", "Converting Celcius to Fahrenheit");
                txtCe.Clear();
                txtCe.Enabled = false;
                celText = false;

            }
            else if (txtF != null && fahText==true)
            {
                var fah = Convert.ToDouble(txtF.Text);
                result = (fah - 32) * 5 / 9;
                MessageBox.Show(fah + " 'F = " + result + " 'C", "Converting Fahrenheit to Celcius");
                txtF.Clear();
                txtF.Enabled = false;
                fahText = false;
            }
            else MessageBox.Show("Please enter Value!!", "Error");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();
            f1.Show();
            this.Hide();
        }


       

      
       

       

        }
}

