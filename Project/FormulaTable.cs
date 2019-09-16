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
    public partial class FormulaTable : Form
    {

        Formula flist = new Formula("(celsius * 9 / 5) + 32", "(fahrenheit - 32) * 5 / 9", "meter*100", "centimeter/1000" );
        public ArrayList list = new ArrayList();
        
                     
        public FormulaTable()
        {
            InitializeComponent();
        }
              

        private void Formulae_Mouse_Click(object sender, DataGridViewCellEventArgs e)
        {
            t1.Text = Formulae.Rows[0].Cells[0].Value.ToString();
            t2.Text = Formulae.Rows[0].Cells[1].Value.ToString();
            t3.Text = Formulae.Rows[0].Cells[2].Value.ToString();
            t4.Text = Formulae.Rows[0].Cells[3].Value.ToString();

            
        }

        private void FormulaTable_Load(object sender, EventArgs e)
        {
            list.Add(flist);
            var q=from Formula p in list
                  select new{p.p1,p.p2,p.p3,p.p4};
           

            foreach(var a in q)
            {
                int n = Formulae.Rows.Add();
                Formulae.Rows[n].Cells[0].Value =a.p1 ;
                Formulae.Rows[n].Cells[1].Value =a.p2;
                Formulae.Rows[n].Cells[2].Value =a.p3;
                Formulae.Rows[n].Cells[3].Value =a.p4;
            }
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            Formulae.Rows[0].Cells[0].Value = t1.Text;
            Formulae.Rows[0].Cells[1].Value = t2.Text;
            Formulae.Rows[0].Cells[2].Value = t3.Text;
            Formulae.Rows[0].Cells[3].Value = t4.Text;
        }
         
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

       

        

       
    }
}
