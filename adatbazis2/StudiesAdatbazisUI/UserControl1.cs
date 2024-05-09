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
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Instructor instructor = listBox1.SelectedItem as Instructor;
            var lessonss = from l in context.Lessons
                           where l.InstructorFk == instructor.InstructorSk
                           select new
                           {
                               Kurzus = l.CourseFkNavigation.Name,
                               Nap = l.DayFkNavigation.Name,
                               Sav = l.TimeFkNavigation.Name
                           };
            dataGridView1.DataSource = lessonss.ToList();
        }
        private void FillDataSource()
        {
            var ilist = from i in context.Instructors
                        where i.Name.Contains(textBox1.Text)
                        select i;
            listBox1.DataSource = ilist.ToList();
        }
    }
}
