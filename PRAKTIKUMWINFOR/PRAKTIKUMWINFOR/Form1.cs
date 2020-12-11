using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRAKTIKUMWINFOR
{
    public partial class Formdata : Form
    {
        public Formdata()
        {
            InitializeComponent();
        }

        private void tombolproses_Click(object sender, EventArgs e)
        {
            
            if (inputteks.Text == "DELETE")
            {
                EMPTY.Text = "[EMPTY]";
            }
            else if (inputteks.Text == "HIDE")
            {
                EMPTY.Visible = false;
            }
            else if (inputteks.Text == "SHOWN")
            {
                EMPTY.Visible = true;
            }
            else if (inputteks.Text == "BLUE")
            {
                this.EMPTY.ForeColor = Color.Blue;               
            }
            else if (inputteks.Text == "RED")
            {
                this.EMPTY.ForeColor = Color.Red;
            }
            else if (inputteks.Text == "GREEN")
            {
                this.EMPTY.ForeColor = Color.Green;
            }
            else
            {
                EMPTY.Text = inputteks.Text;
            }    
            }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           //ABAIKAN
        }

        private void EMPTY_Click(object sender, EventArgs e)
        {
             EMPTY.Text=inputteks.Text  ;
            
        }
    }
}
