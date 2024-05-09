using StudiesAdatbazisUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudiesAdatbazisUI
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
        private void FillDataSource()
        {
            listBox1.DataSource =
            (
                from i in context.Instructors
                where i.Name.Contains(textBox1.Text)
                select i
            ).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Instructor instructor = listBox1.SelectedItem as Instructor;
            dataGridView1.DataSource = 
            (
                from i in context.Instructors
                where i.InstructorSk == instructor.InstructorSk
                select new
                {
                    Nev = i.Name,
                    status = i.StatusFkNavigation.Name,
                    employement = i.EmployementFkNavigation.Name
                }
            ).ToList();
        }
    }
}
