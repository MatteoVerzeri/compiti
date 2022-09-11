using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pizzeria
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form7 form7 = new Form7();
            this.Visible = false;
            form7.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form6 form6 = new Form6();
            this.Visible = false;
            form6.ShowDialog();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./menug.txt"); ;
            string y = sr.ReadLine();
            string stampa = null;
            while (y != null)
            {
                if (y.Split(';')[7] == "True")
                {
                    string n = $"Nome: {y.Split(';')[0]}\nPrezzo: {y.Split(';')[1]}\nPortata: {y.Split(';')[2]}\nIngredienti: {y.Split(';')[3]}\nIngredienti: {y.Split(';')[4]}\nIngredienti: {y.Split(';')[5]}\nIngredienti: {y.Split(';')[6]}";
                    stampa += n + "\n\n";
                }
                y = sr.ReadLine();
            }
            sr.Close();
            MessageBox.Show(stampa);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            this.Visible = false;
            form8.ShowDialog();
            this.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            this.Visible = false;
            form9.ShowDialog();
            this.Visible = true;
        }
    }
}
