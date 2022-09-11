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
            StreamReader sr = new StreamReader(@"./menug.txt");
            string stampa = null;

            /*linea.Split(';');
            string nome = linea.Split(';')[0];
            */
            try
            {



                foreach (string line in System.IO.File.ReadLines(@"./menug.txt"))
                {
                    if (line.Split(';')[0] == textBox1.Text)
                    {






                        string sep = ";";
                        stampa += line.Split(';')[0] + sep + line.Split(';')[1] + sep + line.Split(';')[2] + sep + line.Split(';')[3] + sep + line.Split(';')[4] + sep + line.Split(';')[5] + sep + line.Split(';')[6] + sep + "True\n";

                    }
                    else
                    {

                        stampa += line;
                        stampa += "\n";
                    }
                }
                sr.Close();
                File.WriteAllText(@"./menug.txt", stampa);
                this.Close();
            }
            catch
            {
                throw new Exception("piatto non trovato");
            }
        }
    }
}
