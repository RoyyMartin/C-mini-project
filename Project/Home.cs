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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

       

        private void btnGoToConT_Click(object sender, EventArgs e)
        {
            ConverterT obj = new ConverterT();
            obj.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       

        private void btngoF_Click(object sender, EventArgs e)
        {
            FormulaTable f = new FormulaTable();
            f.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btngoC_Click(object sender, EventArgs e)
        {
            ConverterT f = new ConverterT();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConverterW f = new ConverterW();
            f.Show();
            this.Hide();
        }

      

       

      
        

      

        
    }
}
