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
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fd=new FontDialog();
            DialogResult result=fd.ShowDialog();
            if(result==DialogResult.OK)
            {
                richTextBox1.SelectionFont= fd.Font;
            }

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd=new ColorDialog();
            DialogResult result = cd.ShowDialog();  
            if(result==DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }
    }
}
