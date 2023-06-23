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
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form2 f = new Form2();

            ControlRadar cr = new ControlRadar();

            if(f.ShowDialog() == DialogResult.OK)
            {
                
                string patente = Convert.ToString(f.textBox1.Text);

                double velocidad = Convert.ToDouble(f.textBox2.Text);
                bool esOficial = false;
                Vehiculo v = new Vehiculo(patente, velocidad, esOficial);
                if (f.radioButton1.Checked)
                {
                    
                    esOficial = true;
                }
                else
                {
                    esOficial = false;
                }
                listBox1.Items.Add(v.Velocidad.ToString("00") + " - " + v.Patente);

                
                cr.AgregarControl(patente, velocidad, esOficial);
            }
            
            f.Dispose();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
