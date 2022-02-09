using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MultiplosParesImparesArduino
{
    public partial class frmMultiplosParesImpares : Form
    {
        SerialPort ArduinoPort;
        string[] PuertosDisponibles;
        public frmMultiplosParesImpares()
        {
            InitializeComponent();          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PuertosDisponibles = SerialPort.GetPortNames();

            foreach (var item in PuertosDisponibles)
            {
                cmbx_puerto.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ArduinoPort = new SerialPort();
            ArduinoPort.PortName = cmbx_puerto.GetItemText(cmbx_puerto.SelectedItem);
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();
            ArduinoPort.WriteLine(txtbx_ciclo.Text + "," + txtbx_multiplo.Text);
            ArduinoPort.Close();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Write(Int64.Parse(textBox1.Text)#Int64.Parse(textBox2.Text));
        //    int resultado;
        //    for (int i = 0; i < Int64.Parse(textBox1.Text); i++)
        //    {

        //        resultado = i/Int32.Parse(textBox2.Text);
        //        if (resultado%2==0)
        //        {
                    
        //        }
        //    }
        //}
    }
}
