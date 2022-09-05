using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzeria
{
    
    public partial class Form2 : Form
    {
        string password = "admin";
        string username = "admin";
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form2 = new Form1();
            Form2.ShowDialog();
            this.Close();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == password && textBox2.Text!= null)
            {
                if (textBox1.Text == username && textBox1.Text != null)
                {
                    this.Hide();
                    Form5 Form2 = new Form5();
                    Form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("username o password errati");
                }
            }
            else
            {
                throw new Exception("username o password errati");
            }
        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == password && textBox2.Text != null)
            {
                if (textBox1.Text == username && textBox1.Text != null)
                {
                    this.Hide();
                    Form5 Form2 = new Form5();
                    Form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    throw new Exception("username o password errati");
                }
            }
            else
            {
                throw new Exception("username o password errati");
            }
        }
    }
}
