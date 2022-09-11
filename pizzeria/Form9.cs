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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (checkBox1.Checked == false)
                {
                StreamReader sr = new StreamReader(@"./menug.txt");
                string stampa = null;
                string linea = "";
                string nome = textBox1.Text;

                try
                {
                    
                    foreach (string line in System.IO.File.ReadLines(@"./menug.txt"))
                    {
                        if (line.Contains(nome))
                        {
                            
                            string UwU = null;
                            Label label1 = new Label();
                            float currentSize;
                            currentSize = label1.Font.Size;
                            currentSize += 4.0F;
                            label1.AutoSize = true;
                            label1.Location = new Point(20, 158);
                            label1.Font = new Font(label1.Font.Name, currentSize,
                            label1.Font.Style);
                            UwU = $" nome: {line.Split(';')[0]}\n prezzo: {line.Split(';')[1]}\n portata: {line.Split(';')[2]}\n ingrediente 1: {line.Split(';')[3]}\n ingrediente 2: {line.Split(';')[4]}\n ingrediente 3: {line.Split(';')[5]}\n ingrediente 4: {line.Split(';')[6]}";
                            label1.Text = UwU;
                            this.Controls.Add(label1);
                            string z = linea;
                            if (line.Contains(nome))
                            {
                                stampa += z;
                                stampa += "\n";
                            }
                            else
                            {
                                string sep = ";";
                                stampa += linea.Split(';')[0] + sep + linea.Split(';')[1] + sep + linea.Split(';')[2] + sep + linea.Split(';')[3] + sep + linea.Split(';')[4] + sep + linea.Split(';')[5] + sep + linea.Split(';')[6] + sep + "False" + "\n";
                            }
                        }
                    }
                    sr.Close();
                    File.WriteAllText("./menug.txt", stampa);
                    this.Close();
                }
                catch
                {
                    throw new Exception("piatto non trovato");
                }
                    
                    
                }
                else
                {
                StreamReader sr = new StreamReader(@"./menug.txt");
                string stampa = null;
                
                string nome = textBox1.Text;
                try
                {

                    foreach (string line in System.IO.File.ReadLines(@"./menug.txt"))
                    {
                        if (line.Contains(nome))
                        {
                            string z = line;
                            if (line.Split(';')[0] != textBox1.Text)
                            {
                                stampa += z;
                                stampa += "\n";
                            }
                        }
                    }
                    sr.Close();
                    File.WriteAllText("./menug.txt", stampa);
                    this.Close();
                }
                catch
                {
                    throw new Exception("piatto non trovato");
                } 
                    
                }
            
        }
    }
}
