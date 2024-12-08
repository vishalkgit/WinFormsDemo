using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNetAssesment";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder Exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch (Exception ex) { }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex) { }
        }
    }
}
