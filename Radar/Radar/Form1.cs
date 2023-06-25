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

       
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < cr.CantidadVehiculo; i++)
            {
                Vehiculo v = cr.VerVehiculosInfractores(i);

                listBox1.Items.Add(string.Format("Velocidad " + v.Velocidad + " Patente: " + v.Patente) );
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string patente = textBox1.Text;
            
            cr.MetodoBurbuja();
            int pos = cr.BusquedaBinaria(patente);
            if (pos >= 0)
            {
                
                listBox1.Items.Add(string.Format("Patente: " + cr.VerVehiculosInfractores(pos).Patente));
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();


            while (f.ShowDialog() == DialogResult.OK)
            {
                bool esOficial = false;
                string patente = Convert.ToString(f.textBox1.Text);

                double velocidad = Convert.ToDouble(f.textBox2.Text);


                esOficial = f.radioButton1.Checked;


                cr.AgregarControl(patente, velocidad, esOficial);
                f.textBox1.Clear();
                f.textBox2.Clear();

            }

            f.Dispose();
        }
    }
}
