﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3D_IASR1J
{
    public partial class UserControl3 : UserControl
    {
        Models.SeBikestoreContext seBikestoreContext = new Models.SeBikestoreContext();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =
            (
                from categories in seBikestoreContext.Categories
                select categories
            ).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2();
        }
    }
}
