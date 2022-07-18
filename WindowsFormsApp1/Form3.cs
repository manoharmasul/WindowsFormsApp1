using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        FileStream fs;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product Prod = new Product();
                Prod.Id = Convert.ToInt32(txtId.Text);
                Prod.Name =txtName.Text;
                Prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"C:\Users\DELL\Documents\Test\Product", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Prod);
                MessageBox.Show("File Created");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();

            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"C:\Users\DELL\Documents\Test\Product", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                prod = (Product)bf.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product Prod = new Product();
                Prod.Id = Convert.ToInt32(txtId.Text);
                Prod.Name = txtName.Text;
                Prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"C:\Users\DELL\Documents\Test\ProductXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product));


                xs.Serialize(fs, Prod);
                MessageBox.Show("File Created");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();

            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"C:\Users\DELL\Documents\Test\ProductXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product));

                prod = (Product)xs.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product Prod = new Product();
                Prod.Id = Convert.ToInt32(txtId.Text);
                Prod.Name = txtName.Text;
                Prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"C:\Users\DELL\Documents\Test\ProductSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();

                sf.Serialize(fs, Prod);
                MessageBox.Show("File Created");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();

            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"C:\Users\DELL\Documents\Test\ProductSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();

                prod = (Product)sf.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);
                fs = new FileStream(@"C:\Users\DELL\Documents\Test\ProductJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs,prod);
                MessageBox.Show("File Created");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();

            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                fs = new FileStream(@"C:\Users\DELL\Documents\Test\ProductJson", FileMode.Open, FileAccess.Read);
                prod = JsonSerializer.Deserialize<Product>(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
