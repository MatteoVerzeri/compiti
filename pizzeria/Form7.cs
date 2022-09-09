﻿using System;
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
            foreach (string line in System.IO.File.ReadLines(@"./menu.txt"))
            {
                if (line.Contains(nome))
                {
                    if(textBox2.Text != null)
                    {
                        mod += textBox2.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[0];
                    }
                    mod += ";";
                    if (textBox3.Text != null)
                    {
                        mod += textBox3.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[1];
                        try
                        {
                            double conv = Convert.ToDouble(textBox1.Text);
                        }
                        catch
                        {
                            throw new Exception("inserire un prezzo valido");
                        }
                    }
                    mod += ";";
                    if (textBox4.Text != null)
                    {
                        mod += textBox4.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[2];
                    }
                    mod += ";";
                    if (textBox5.Text != null)
                    {
                        mod += textBox5.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[3];
                    }
                    mod += ";";
                    if (textBox6.Text != null)
                    {
                        mod += textBox6.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[4];
                    }
                    mod += ";";
                    if (textBox7.Text != null)
                    {
                        mod += textBox7.Text;
                    }
                    else
                    {
                        mod += line.Split(';')[5];
                    }
                    mod += ";";
                    if (textBox8.Text != null)
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
            StreamReader sr = new StreamReader("./menu.txt");
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
            File.WriteAllText("./menu.txt", stampatutto);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifica();
        }
    }
}
