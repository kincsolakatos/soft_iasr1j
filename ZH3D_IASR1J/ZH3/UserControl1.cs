using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3D_IASR1J.Models;

namespace ZH3D_IASR1J
{
    public partial class UserControl1 : UserControl
    {
        SeBikestoreContext seBikestoreContext = new SeBikestoreContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
            (
                from products in seBikestoreContext.Products
                select new
                {
                    ID = products.ProductSk,
                    Nev = products.ProductName,
                    Marka = products.BrandId, //nincs BrandFKNavigation
                    Kategoria = products.CategoryFkNavigation.CategoryName,
                    Ev = products.ModelYear,
                    Ar = products.ListPrice
                }
            ).ToList(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = from productss in seBikestoreContext.Products
                           select productss;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                CsvWriter csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                var list = products.ToList();
                csvWriter.WriteRecords(list);
                streamWriter.Close();
            }
        }
    }
}
