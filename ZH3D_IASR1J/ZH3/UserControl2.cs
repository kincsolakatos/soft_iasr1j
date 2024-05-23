using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3D_IASR1J.Models;

namespace ZH3D_IASR1J
{
    public partial class UserControl2 : UserControl
    {
        Models.SeBikestoreContext seBikestoreContext = new Models.SeBikestoreContext();
        public UserControl2()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "BrandName";
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
        private void FillDataSource()
        {
            listBox1.DataSource =
            (
                from brands in seBikestoreContext.Brands
                where brands.BrandName.Contains(textBox1.Text)
                select brands
            ).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Brand selectedBrand = (Brand)listBox1.SelectedItem;
            dataGridView1.DataSource =
            (
                from products in seBikestoreContext.Products
                where products.BrandId == selectedBrand.BrandSk
                select new
                {
                    Nev = products.ProductName,
                    Marka = selectedBrand.BrandName,
                    Kategoria = products.CategoryFkNavigation.CategoryName,
                    Ev = products.ModelYear,
                    Ar = products.ListPrice
                }
            ).ToList();
        }
    }
}
