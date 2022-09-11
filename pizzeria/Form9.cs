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
        public void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {


                try
                {

                    /*foreach (string line in System.IO.File.ReadLines(@"./menug.txt"))
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
                    this.Close();*/
                    if (checkBox1.Checked == true)
                    {
                        StreamReader sr1 = new StreamReader("./menug.txt");
                        string x = textBox1.Text;
                        string stampatutto = null;
                        string y = "";

                        while (y != null)
                        {
                            y = sr1.ReadLine();
                            if (y != null)
                            {

                                string z = y;
                                if (y.Split(';')[0] != textBox1.Text)
                                {
                                    stampatutto += z;
                                    stampatutto += "\n";
                                }
                            }
                        }
                        sr1.Close();
                        File.WriteAllText("./menug.txt", stampatutto);
                        this.Close();
                    }
                }
                catch
                {
                    throw new Exception("piatto non trovato");
                }
            }
            else
            {
                throw new Exception("hai tolto la spunta, non ho potuto cancellare fisicamente il file");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (checkBox1.Checked == false)
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
                                stampa += line.Split(';')[0] + sep + line.Split(';')[1] + sep + line.Split(';')[2] + sep + line.Split(';')[3] + sep + line.Split(';')[4] + sep + line.Split(';')[5] + sep + line.Split(';')[6] + sep + "False\n";
                            
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
                
                    
                    
                
                if(checkBox1.Checked == true)
                {
                Label label3 = new Label();
                float currentSize;
                currentSize = label3.Font.Size;
                currentSize += 4.0F;
                label3.AutoSize = true;
                label3.Location = new Point(284, 250);
                label3.Font = new Font(label3.Font.Name, currentSize,
                label3.Font.Style);
                label3.Text = "Sei sicuro di voler eliminare fisicamente questo piatto?\nL'azione non è reversibile quindi non potrai più recuperarlo.";
                this.Controls.Add(label3);
                Button button2 = new Button();
                button2.AutoSize = true;
                button2.Location = new Point(284, 300);
                button2.Text = "Conferma";
                this.Controls.Add(button2);
                /*StreamReader sr = new StreamReader(@"./menug.txt");
                string stampa = null;
                
                string nome = textBox1.Text;*/
                button2.Click += new EventHandler(button2_Click);
                
            
        }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                StreamReader sr1 = new StreamReader("./menug.txt");

                string stampatutto = null;
                string y = "";

                while (y != null)
                {
                    y = sr1.ReadLine();
                    if (y != null)
                    {

                        string z = y;
                        if (y.Split(';')[7] != "False")
                        {
                            stampatutto += z;
                            stampatutto += "\n";
                        }
                    }
                }
                sr1.Close();
                File.WriteAllText("./menug.txt", stampatutto);
                this.Close();
            
        }
    }
}
