using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void REVERSE_Click(object sender, EventArgs e)
        {
            if (inputbox.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu!");
            }
            else
            {
                string reverse;
                char[] index = inputbox.Text.ToCharArray();
                Array.Reverse(index);
                reverse = new string(index);

                OUTPUT.Text = reverse;
            }
        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void OUTPUT_Click(object sender, EventArgs e)
        {
            
        }

        private void URUTKAN_Click(object sender, EventArgs e)
        {
            if (inputbox.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu!");
            }
            else
            {
                string SORT;
                char[] index = inputbox.Text.ToCharArray();
                Array.Sort(index);
                SORT = new string(index);

                OUTPUT.Text = SORT;
               
            }

        }


    }
}
