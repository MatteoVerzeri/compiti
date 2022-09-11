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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.ShowDialog();
            this.Visible = true;
        }

        string[] lista = new string[1000];
        string[] lista2 = new string[1000];
        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./menug.txt"); ;
            string y = sr.ReadLine();
            int count = 0;

             while (y != null)
             {
                 if (y.Split(';')[7] == "True")
                 {
                     //lista[count] = $"Nome: {y.Split(';')[0]}\tPrezzo: €{y.Split(';')[1]} \tPortata: {y.Split(';')[2]}\tIngredienti: {y.Split(';')[3]}\tIngredienti: {y.Split(';')[4]}\tIngredienti: {y.Split(';')[5]}\tIngredienti: {y.Split(';')[6]}";
                     //listBox1.Items.Add(lista[count]);


                         lista[count] = $"Nome: {y.Split(';')[0]}\tPrezzo: €{y.Split(';')[1]} \tPortata: {y.Split(';')[2]}\tIngredienti: {y.Split(';')[3]}\tIngredienti: {y.Split(';')[4]}\tIngredienti: {y.Split(';')[5]}\tIngredienti: {y.Split(';')[6]}";
                         listBox1.Items.Add(lista[count]);


                 }
                 y = sr.ReadLine();
                 count++;
             }
            sr.Close();


            StreamReader sr1 = new StreamReader("./menug.txt"); ;
            y = "";
            count = 0;
            while (y != null)
            {
                y = sr1.ReadLine();
                if (y != null)
                {
                    if (y.Split(';')[4] == "True")
                    {
                        lista2[count] = y;
                    }
                    count++;
                }
            }
        }
        
            
        

        private void button2_Click(object sender, EventArgs e)
        {
            string[] w = new string[listBox2.Items.Count + 1];
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string x = listBox2.Items[i].ToString();
                for (int y = 0; y < x.Length; y++)
                {
                    if (x[y] == '€')
                    {
                        for (int z = y; x[z] != ' '; z++)
                        {
                            w[i] += x[z];
                        }
                    }
                }
            }
            double[] pippo = new double[listBox2.Items.Count];
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                w[i] = w[i].Substring(1);
                pippo[i] = Convert.ToDouble(w[i]);
            }
            label3.Text = "€" + Convert.ToString(pippo.Sum());
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string x = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(x);
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.ShowDialog();
            this.Visible = true;
        }
    }
}
