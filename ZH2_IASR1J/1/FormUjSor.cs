using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class FormUjSor : Form
    {
        public Ital UjItal = new Ital();
        public FormUjSor()
        {
            InitializeComponent();
        }
        private void FormUjSor_Load(object sender, EventArgs e)
        {

        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            UjItal.ItalID = int.Parse(textBoxItalID.Text);
            UjItal.Nev = textBoxNev.Text;
            UjItal.Alkoholtartalom = int.Parse(textBoxAlkoholtartalom.Text);
            UjItal.EgysegAr = int.Parse(textBoxEgysegAr.Text);
            UjItal.Nepszeru = checkBoxNepszeru.Checked;
            bindingSource1.DataSource = UjItal;
        }
    }
}
