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
        Timer timer_x = new Timer();

        IDictionary<int, int> graphCoords = new Dictionary<int, int>();

        // y = Math.pow(Math.e, x/100)

        bool isTimerOn = false;

        public frm_darkside()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer_x.Interval = 1000;
            timer_x.Enabled = true;

            
        }

        private void timer_x_Tick(object sender, EventArgs e)
        {
            timer_x.Start();
            //this.Time.Text = System.DateTime.Now.ToString("s t");
        }
    }
}
