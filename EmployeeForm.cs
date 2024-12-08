using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsDemo
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeBinary.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();    
                Employee emp= new Employee();
                emp.Id=Convert.ToInt32(txtId.Text);
                emp.Name=txtName.Text;
                emp.Sal=Convert.ToInt32(txtSal.Text);
                binaryFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeBinary.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();    
                Employee emp= new Employee();
                emp=(Employee)binaryFormatter.Deserialize(fs);
                txtId.Text=emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSal.Text=emp.Sal.ToString();
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
            txtSal.Clear();
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeXml.xml", FileMode.Create, FileAccess.Write);
                Employee emp=new Employee();
                emp.Id=Convert.ToInt32(txtId.Text);
                emp.Name=txtName.Text;
                emp.Sal=Convert.ToInt32(txtSal.Text);
                fs.Close();
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
                FileStream fs = new FileStream(@"D:\EmployeeXml.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                Employee emp = new Employee();
                emp = (Employee)xmlSerializer.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSal.Text=emp.Sal.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeSoap.soap",FileMode.Create,FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Sal = Convert.ToInt32(txtSal.Text);
                soapFormatter.Serialize(fs, emp);
                fs.Close();
                MessageBox.Show("Done");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\EmployeeSoap.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Employee emp = new Employee();
                emp = (Employee)soapFormatter.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSal.Text = emp.Sal.ToString();
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
                FileStream fs = new FileStream(@"D:\EmployeeJson.json", FileMode.Create, FileAccess.Write);
                Employee emp = new Employee();
                
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Sal = Convert.ToInt32(txtSal.Text);


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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

       
    }

