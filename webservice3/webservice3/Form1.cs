using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webservice3
{
    public partial class Form1 : Form
    {
        localhost.WebService1 ws = new localhost.WebService1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ws.HelloWorld();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            localhost.Customer cst=new localhost.Customer();

            cst.Name = textBox1.Text;
            cst.Email = textBox2.Text;
            cst.OrderDetail = textBox3.Text;

            string msg= ws.Add(cst);
            MessageBox.Show(msg);
            dataGridView1.DataSource = ws.HelloWorld();

        }
    }
}
