using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class LBox : Form
    {
        public LBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Contains(txtCity.Text))
            {
                MessageBox.Show("Duplicate entries not allowed");
            }
            else
            {
                listBox1.Items.Add(txtCity.Text);
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCity.Clear();
        }
    }
}
