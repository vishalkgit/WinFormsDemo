using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Linq;
// For Bianry serialization
using System.Runtime.Serialization.Formatters.Binary;
//for Soap
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
// for xml serialization


namespace WinFormsDemo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\binaryDemo.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                binaryFormatter.Serialize(fs, prod);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\binaryDemo.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Product prod = new Product();
                prod = (Product)binaryFormatter.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();

        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\xmlDemo.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                xmlSerializer.Serialize(fs, prod);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\xmlDemo.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                Product prod = new Product();
                prod = (Product)xmlSerializer.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\soapDemo.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                soapFormatter.Serialize(fs, prod);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\soapDemo.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Product prod = new Product();
                prod = (Product)soapFormatter.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\jsonDemo.json", FileMode.Create, FileAccess.Write);
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                JsonSerializer.Serialize<Product>(fs, prod);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\soapDemo.soap", FileMode.Open, FileAccess.Read);
                Product prod = new Product();
                prod = JsonSerializer.Deserialize<Product>(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
