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

            ArduinoPort = new SerialPort();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            ArduinoPort.PortName = cmbx_puerto.GetItemText(cmbx_puerto.SelectedItem);
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();
            ArduinoPort.WriteLine("abcd");
            ArduinoPort.Close();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            bool error = false;

            if(Int32.Parse(txtbx_multiplo.Text) == 2 ||
               Int32.Parse(txtbx_multiplo.Text) == 3 ||
               Int32.Parse(txtbx_multiplo.Text) == 5 ||
               Int32.Parse(txtbx_multiplo.Text) == 7)
            {
                ArduinoPort.Open();
                ArduinoPort.WriteLine(txtbx_ciclo.Text + "," + txtbx_multiplo.Text);
                ArduinoPort.Close();
            }
            else
            {
                MessageBox.Show("Multiples incorrectes.", "Arduino Controller - ERROR 007");
            }
        }
    }
}
