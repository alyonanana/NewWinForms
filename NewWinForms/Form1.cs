using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWinForms
{
    public partial class Form1 : Form
    {
        private List<Person> list;
        private Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            list = new List<Person>();
            DataTable(list);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataTable(List<Person> list)
        {
            
            DataTable tabel=new DataTable("name");
            tabel.Columns.Add("Id");
            tabel.Columns.Add("Name");
            tabel.Columns.Add("Surname");
            tabel.Columns.Add("Age");

            for (int i = 0; i < list.Count; i++)
                tabel.Rows.Add(i + 1, list[i].Name, list[i].Surname, list[i].Age);     
            

            this.dataGridView1.DataSource = tabel;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string surname = this.textBox2.Text;
            int age = Convert.ToInt32(this.textBox3.Text);
            Person p = new Person(name,surname,age);
            list.Add(p);
            DataTable(list);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(f2.getText);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
