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
    public partial class Form2 : Form
    {
        Models.SeBikestoreContext seBikestoreContext = new Models.SeBikestoreContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newCategorySK = (int)numericUpDown1.Value;
            string newCategoryName = textBox1.Text;
            Category newCategory = new Category { CategorySk = newCategorySK, CategoryName = newCategoryName};
            seBikestoreContext.Categories.Add(newCategory);
            seBikestoreContext.SaveChanges();
        }
    }
}
