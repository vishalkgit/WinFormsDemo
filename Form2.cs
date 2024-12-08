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
using System.Xml.Linq;

namespace WinFormsDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNet-10AMBatch";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder is exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNet-10AMBatch\TestFile.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("Folder is exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // BinaryWriter
                string path = @"D:\DotNet-10AMBatch\emp.dat"; // .dat - data file
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textBox1.Text));
                bw.Write(textBox2.Text);
                bw.Write(Convert.ToDouble(textBox3.Text));
                bw.Close();
                fs.Close();// fs always open a file in buffer, once we close fs, file will be stored back to secondary storage
                MessageBox.Show("Data added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DotNet-10AMBatch\emp.dat"; // .dat - data file
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textBox1.Text = br.ReadInt32().ToString(); // Id
                textBox2.Text = br.ReadString(); // Name
                textBox3.Text = br.ReadDouble().ToString();// Salary
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {

            }


        }
    }
}


    

