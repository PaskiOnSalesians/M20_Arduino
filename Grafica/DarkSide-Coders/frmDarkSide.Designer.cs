
namespace DarkSide_Coders
{
    partial class frm_darkside
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.txtbox_info = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_explorer = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ch_dark = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listview_coords = new System.Windows.Forms.ListView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer_x = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_dark)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_info
            // 
            this.txtbox_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.txtbox_info.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtbox_info.ForeColor = System.Drawing.Color.White;
            this.txtbox_info.Location = new System.Drawing.Point(817, 0);
            this.txtbox_info.Name = "txtbox_info";
            this.txtbox_info.Size = new System.Drawing.Size(268, 326);
            this.txtbox_info.TabIndex = 1;
            this.txtbox_info.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_explorer);
            this.panel1.Controls.Add(this.txt_path);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 77);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(566, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruta TXT File:";
            // 
            // btn_explorer
            // 
            this.btn_explorer.Location = new System.Drawing.Point(1103, 34);
            this.btn_explorer.Name = "btn_explorer";
            this.btn_explorer.Size = new System.Drawing.Size(29, 20);
            this.btn_explorer.TabIndex = 2;
            this.btn_explorer.Text = "...";
            this.btn_explorer.UseVisualStyleBackColor = true;
            this.btn_explorer.Click += new System.EventHandler(this.btn_explorer_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(670, 34);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(427, 20);
            this.txt_path.TabIndex = 1;
            this.txt_path.Text = "C:\\temp\\calibration.txt";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_start.FlatAppearance.BorderSize = 4;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(75, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(228, 42);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start calibration";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 47);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(1132, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 326);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 326);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ch_dark);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.listview_coords);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txtbox_info);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(47, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1085, 326);
            this.panel5.TabIndex = 6;
            // 
            // ch_dark
            // 
            this.ch_dark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ch_dark.BackSecondaryColor = System.Drawing.Color.White;
            this.ch_dark.BorderSkin.BackColor = System.Drawing.Color.White;
            this.ch_dark.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.Maximum = 1000D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScaleView.SmallScrollMinSize = 0D;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.Maximum = 25000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.LightGoldenrodYellow;
            chartArea1.Name = "ChartArea1";
            this.ch_dark.ChartAreas.Add(chartArea1);
            this.ch_dark.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.ch_dark.Legends.Add(legend1);
            this.ch_dark.Location = new System.Drawing.Point(0, 0);
            this.ch_dark.Name = "ch_dark";
            this.ch_dark.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ch_dark.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.LawnGreen};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Dades";
            this.ch_dark.Series.Add(series1);
            this.ch_dark.Size = new System.Drawing.Size(479, 326);
            this.ch_dark.TabIndex = 5;
            this.ch_dark.Text = "ch_dark";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "DarkSide Coders";
            title1.Text = "DarkSide Coders";
            this.ch_dark.Titles.Add(title1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(479, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(43, 326);
            this.panel7.TabIndex = 4;
            // 
            // listview_coords
            // 
            this.listview_coords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listview_coords.Dock = System.Windows.Forms.DockStyle.Right;
            this.listview_coords.ForeColor = System.Drawing.Color.White;
            this.listview_coords.HideSelection = false;
            this.listview_coords.Location = new System.Drawing.Point(522, 0);
            this.listview_coords.Name = "listview_coords";
            this.listview_coords.Size = new System.Drawing.Size(255, 326);
            this.listview_coords.TabIndex = 3;
            this.listview_coords.UseCompatibleStateImageBehavior = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(777, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 326);
            this.panel6.TabIndex = 2;
            // 
            // timer_x
            // 
            this.timer_x.Interval = 1;
            this.timer_x.Tick += new System.EventHandler(this.timer_x_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_darkside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_darkside";
            this.Text = "DarkSide Charts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_darkside_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ch_dark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtbox_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_dark;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView listview_coords;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer_x;
        private System.Windows.Forms.Button btn_explorer;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}

