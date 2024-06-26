﻿using StudiesAdatbazisUI.Models;
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
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Course course = listBox1.SelectedItem as Course;
            var lessonss = from l in context.Lessons
                           where l.CourseFk == course.CourseSk
                           select new
                           {
                               Nap = l.DayFkNavigation.Name,
                               Sav = l.TimeFkNavigation.Name,
                               Oktato = l.InstructorFkNavigation.Name
                           };
            dataGridView1.DataSource = lessonss.ToList();
        }
        private void FillDataSource()
        {
            var ilist = from c in context.Courses
                        where c.Name.Contains(textBox1.Text)
                        select c;
            listBox1.DataSource = ilist.ToList();
        }
    }
}
