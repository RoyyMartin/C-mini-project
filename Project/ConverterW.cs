using System;
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
    public partial class ConverterW : Form
    {
        Boolean gTxt= false; Boolean kgTxt = false; double result;
        public ConverterW()
        {
            InitializeComponent();
        }

        private void btnKtoG_Click(object sender, EventArgs e)
        {
            if (txtg.Enabled == true)
            { MessageBox.Show("You cannot convert both at a time!!", "Error"); }
            else txtkg.Enabled = true;
        }

        private void btnCToM_Click(object sender, EventArgs e)
        {
            if (txtkg.Enabled == true)
            { MessageBox.Show("You cannot convert both at a time!!", "Error"); }
            else txtg.Enabled = true;
        }

        private void txtkg_TextChanged(object sender, EventArgs e)
        {
            kgTxt = true;
        }

        private void txtg_TextChanged(object sender, EventArgs e)
        {
            gTxt = true;
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            if (kgTxt == true && txtkg != null)
            {
                var kg = Convert.ToDouble(txtkg.Text);
                result = kg*1000;
                MessageBox.Show(kg + " kg = " + result + " g", "Converting kilogram to gram");
                txtkg.Clear();
                txtkg.Enabled = false;
                kgTxt = false;

            }
            else if (gTxt == true && txtg != null  )
            {
                var g = Convert.ToDouble(txtg.Text);
                result =g/1000;
                MessageBox.Show(g + " g = " + result + " kg", "Converting gram to kilogram");
                txtg.Clear();
                txtg.Enabled = false;
                gTxt = false;
            }
            else MessageBox.Show("Please enter Value!!", "Error");
        }

        private void ConvertL_Load(object sender, EventArgs e)
        {
            txtkg.Enabled = false;
            txtg.Enabled = false;
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

        private void label2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

       

        
    }
}
