using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radar
{
    public partial class Form1 : Form
    {
        ControlRadar cr = new ControlRadar();
        
        public Form1()
        {
            InitializeComponent();
        }

        Vehiculo v = null;

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();


            while (f.ShowDialog() == DialogResult.OK)
            {
                
                string patente = Convert.ToString(f.textBox1.Text);

                double velocidad = Convert.ToDouble(f.textBox2.Text);
                
                
                bool esOficial = f.radioButton1.Checked;

                
                cr.AgregarControl(patente, velocidad, esOficial);
                f.textBox1.Clear();
                f.textBox2.Clear();
                
            }
            
            f.Dispose();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           double velocidad = 0;
           string patente = "";
           listBox1.Items.Add(velocidad.ToString("Velocidad: 00") + " - patente: " + patente);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();

            string patente = Convert.ToString(f.textBox1.Text);

            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
