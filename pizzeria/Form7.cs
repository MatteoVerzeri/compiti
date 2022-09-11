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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        public void modifica()
        {
            string nome = Convert.ToString(textBox1.Text);
            
            string mod = null;
            int counter = 0;

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"./menug.txt"))
            {
                if (line.Contains(nome))
                {
                    if(textBox2.Text != "")
                    {
                        mod += textBox2.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[0];
                    }
                    mod += ";";
                    if (textBox3.Text != "")
                    {
                        mod += textBox3.Text;
                        if (textBox3.Text != null)
                        {
                            try
                            {
                                double conv = Convert.ToDouble(textBox3.Text);
                            }
                            catch
                            {
                                throw new Exception("inserire un prezzo valido");
                            }
                        }
                    }
                    else
                    {
                        mod += line.Split(';')[1];  
                    }
                    mod += ";";
                    if (textBox4.Text != "" )
                    {
                        mod += textBox4.Text;
                    }
                    else if (textBox4.Text != "primo" || textBox4.Text != "secondo" || textBox4.Text != "contorno" || textBox4.Text != "dolce")
                    {
                        mod += line.Split(';')[2];
                        MessageBox.Show("la portata non è stata cambiata");
                    }
                    else
                    {
                        
                        mod += line.Split(';')[2];
                    }

                    
                    mod += ";";
                    if (textBox5.Text != "")
                    {
                        mod += textBox5.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[3];
                    }
                    mod += ";";
                    if (textBox6.Text != "")
                    {
                        mod += textBox6.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[4];
                    }
                    mod += ";";
                    if (textBox7.Text != "")
                    {
                        mod += textBox7.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[5];
                    }
                    mod += ";";
                    if (textBox8.Text != "")
                    {
                        mod += textBox8.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[6];
                    }
                    mod += ";";
                    mod += line.Split(';')[7];
                }
                else
                {
                    counter++;
                }
                
            }
            StreamReader sr = new StreamReader("./menug.txt");
            string linea = "";
            string stampatutto = null;
            linea = "";
            while (linea != null)
            {
                linea = sr.ReadLine();
                if (linea != null)
                {
                    string z = linea;
                    if (linea.Split(';')[0] != textBox1.Text)
                    {
                        stampatutto += z;
                        stampatutto += "\n";
                    }
                    else
                    {
                        stampatutto += mod;
                        stampatutto += "\n";
                    }
                }
            }
            sr.Close();
            File.WriteAllText("./menug.txt", stampatutto);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifica();
        }
    }
}
