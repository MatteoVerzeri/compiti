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
    public partial class Form8 : Form
    {
        
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string UwU = null;
            foreach (string line in System.IO.File.ReadLines(@"./menug.txt"))
            {
                if (line.Contains(nome))
                {
                    try
                    {
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
                    }
                    catch
                    {
                        throw new Exception("piatto non trovato, ricontrolla il nome");
                    }
                    
                }
            }
        }
    }
}
