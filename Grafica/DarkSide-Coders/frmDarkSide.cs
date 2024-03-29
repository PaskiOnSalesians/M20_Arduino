﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkSide_Coders
{
    public partial class frm_darkside : Form
    {
        Dictionary<double, double> graphCoords = new Dictionary<double, double>();
        double x = 0, y;

        String fullPath;

        public frm_darkside()
        {
            InitializeComponent();
        }

        private void timer_x_Tick(object sender, EventArgs e)
        {
            if (x <= 1000)
            {
                y = Math.Pow(Math.E, x / 100);

                y = Math.Round(y, 3, MidpointRounding.AwayFromZero);

                graphCoords.Add(x, y);

                ch_dark.Series["Dades"].Points.AddXY(x, y);

                if(x % 25 == 0)
                {
                    string[] row = { x.ToString(), y.ToString() };
                    ListViewItem lvi = new ListViewItem(row);
                    listview_coords.Items.Add(lvi);
                }
                x += 1;
            }
            else
            {
                timer_x.Stop();

                fullPath = txt_path.Text;
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    sw.WriteLine("Time, Temperature");
                    foreach (KeyValuePair<double, double> kvp in graphCoords)
                    {
                        sw.WriteLine(string.Format("{0} | {1}", kvp.Key, kvp.Value));
                    }
                }
                    

                txtbox_info.Text = File.ReadAllText(fullPath);
            }
        }

        private void frm_darkside_Load(object sender, EventArgs e)
        {
            listview_coords.View = View.Details;
            listview_coords.Columns.Add("Time");
            listview_coords.Columns.Add("Temperature");
        }

        private void btn_explorer_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "txt files (*.txt)|*.txt";
            sfd.InitialDirectory = "C:\\temp\\calibration.txt";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = Path.GetFullPath(sfd.FileName);
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
