
namespace MultiplosParesImparesArduino
{
    partial class frmMultiplosParesImpares
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
            this.LblPuerto = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblMultiplo = new System.Windows.Forms.Label();
            this.cmbx_puerto = new System.Windows.Forms.ComboBox();
            this.txtbx_ciclo = new System.Windows.Forms.TextBox();
            this.txtbx_multiplo = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblPuerto
            // 
            this.LblPuerto.AutoSize = true;
            this.LblPuerto.Location = new System.Drawing.Point(90, 72);
            this.LblPuerto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPuerto.Name = "LblPuerto";
            this.LblPuerto.Size = new System.Drawing.Size(41, 13);
            this.LblPuerto.TabIndex = 0;
            this.LblPuerto.Text = "Puerto:";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(90, 132);
            this.LblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(47, 13);
            this.LblNumero.TabIndex = 1;
            this.LblNumero.Text = "Numero:";
            // 
            // LblMultiplo
            // 
            this.LblMultiplo.AutoSize = true;
            this.LblMultiplo.Location = new System.Drawing.Point(90, 194);
            this.LblMultiplo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMultiplo.Name = "LblMultiplo";
            this.LblMultiplo.Size = new System.Drawing.Size(43, 13);
            this.LblMultiplo.TabIndex = 2;
            this.LblMultiplo.Text = "Multiplo";
            // 
            // cmbx_puerto
            // 
            this.cmbx_puerto.FormattingEnabled = true;
            this.cmbx_puerto.Location = new System.Drawing.Point(173, 72);
            this.cmbx_puerto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbx_puerto.Name = "cmbx_puerto";
            this.cmbx_puerto.Size = new System.Drawing.Size(92, 21);
            this.cmbx_puerto.TabIndex = 3;
            // 
            // txtbx_ciclo
            // 
            this.txtbx_ciclo.Location = new System.Drawing.Point(173, 132);
            this.txtbx_ciclo.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_ciclo.Name = "txtbx_ciclo";
            this.txtbx_ciclo.Size = new System.Drawing.Size(76, 20);
            this.txtbx_ciclo.TabIndex = 4;
            // 
            // txtbx_multiplo
            // 
            this.txtbx_multiplo.Location = new System.Drawing.Point(173, 194);
            this.txtbx_multiplo.Margin = new System.Windows.Forms.Padding(2);
            this.txtbx_multiplo.Name = "txtbx_multiplo";
            this.txtbx_multiplo.Size = new System.Drawing.Size(76, 20);
            this.txtbx_multiplo.TabIndex = 5;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(287, 72);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(56, 19);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(287, 194);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(56, 19);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Enviar";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // frmMultiplosParesImpares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.txtbx_multiplo);
            this.Controls.Add(this.txtbx_ciclo);
            this.Controls.Add(this.cmbx_puerto);
            this.Controls.Add(this.LblMultiplo);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblPuerto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMultiplosParesImpares";
            this.Text = "Multiplos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPuerto;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblMultiplo;
        private System.Windows.Forms.ComboBox cmbx_puerto;
        private System.Windows.Forms.TextBox txtbx_ciclo;
        private System.Windows.Forms.TextBox txtbx_multiplo;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_send;
    }
}

