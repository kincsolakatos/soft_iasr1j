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
    public partial class UserControl4 : UserControl
    {
        Models.SeBikestoreContext seBikestoreContext = new Models.SeBikestoreContext();
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            listBox1.DataSource =
            (
                from products in seBikestoreContext.Products
                orderby products.ListPrice descending
                select products.ListPrice

            ).ToList();
            listBox1.DisplayMember = "ListPrice";
            label1.Text = $"{}";
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
            ).ToList();
            label2.Text = $"{}";
        }

    }
}
