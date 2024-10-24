using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Form_Quản_Lý_Danh_Sách_Sinh_Viên
{
    public partial class Form1 : Form
    {
        List<Student> studentList = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                ID = textBox1.Text,
                Name = textBox2.Text,
                Class = textBox3.Text
            };
            studentList.Add(student);
            RefreshGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string selectedId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Student student = studentList.Find(s => s.ID == selectedId);

                student.ID = textBox1.Text;
                student.Name = textBox2.Text;
                student.Class = textBox3.Text;

                RefreshGridView();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string selectedId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                studentList.RemoveAll(s => s.ID == selectedId);
                RefreshGridView();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentList;
        }
        public class Student
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Class { get; set; }
        }
    }
}
