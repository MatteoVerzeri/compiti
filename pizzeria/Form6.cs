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
    public partial class Form6 : Form
    {
        
        
        public Form6()
        {
            InitializeComponent();
        }
        
        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            uniscipiatto();
            MessageBox.Show("Piatto inserito con successo");
            
        }
        public static void scriviAppend(string filename, string content)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
            oStream.Close();
        }
        public void uniscipiatto() 
        {
            double r;
            try
            {
                 r = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                throw new Exception("inserire un prezzo valido");
            }
            string piattocompleto;
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox3.Text == "primo" || textBox3.Text == "secondo" || textBox3.Text == "contorno" || textBox3.Text == "dolce" && textBox4.Text != null && textBox5.Text != null && textBox6.Text != null && textBox7.Text != null)
            {
                if( r == Convert.ToDouble(textBox2.Text)){
                    string sep = ";";
                    piattocompleto = textBox1.Text + sep + textBox2.Text + sep + textBox3.Text + sep + textBox4.Text + sep + textBox5.Text + sep + textBox6.Text + sep + textBox7.Text + sep + "True";
                    scriviAppend(@"./menug.txt", piattocompleto);
                    this.Close();
                }    
            }
            else
            {
                throw new Exception("dati inseriti non validi");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
