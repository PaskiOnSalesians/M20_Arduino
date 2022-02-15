using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkSide_Coders
{
    public partial class frm_darkside : Form
    {
        IDictionary<double, double> graphCoords = new Dictionary<double, double>();
        double x = 1, y;

        public frm_darkside()
        {
            InitializeComponent();
        }

        private void timer_x_Tick(object sender, EventArgs e)
        {
            if (x < 1000)
            {
                x += 1;
                y = Math.Pow(Math.E, x / 100);

                Console.WriteLine(x);
                Console.WriteLine(y);
                ch_dark.Series["Dades"].Points.AddXY(x, y);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer_x.Start();

            if (x > 1000)
            {
                timer_x.Stop();
            }
        }

    }
}
