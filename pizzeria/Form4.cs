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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Visible = false;
            form3.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* string filename;
            string content;
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(content);
                sw.Close();*/
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
