namespace MG1.Comedor.Presentacion
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTPFechaMenu = new System.Windows.Forms.DateTimePicker();
            this.cb_Programacion = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dg_Alimento = new System.Windows.Forms.DataGridView();
            this.cb_Alimento = new System.Windows.Forms.ComboBox();
            this.btn_GuardarDetalleServicio = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.dg_DetalleServicio = new System.Windows.Forms.DataGridView();
            this.cb_EmpleadoServicio = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Alimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DetalleServicio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTPFechaMenu
            // 
            this.dateTPFechaMenu.Location = new System.Drawing.Point(94, 14);
            this.dateTPFechaMenu.Name = "dateTPFechaMenu";
            this.dateTPFechaMenu.Size = new System.Drawing.Size(185, 20);
            this.dateTPFechaMenu.TabIndex = 58;
            // 
            // cb_Programacion
            // 
            this.cb_Programacion.FormattingEnabled = true;
            this.cb_Programacion.Location = new System.Drawing.Point(94, 93);
            this.cb_Programacion.Name = "cb_Programacion";
            this.cb_Programacion.Size = new System.Drawing.Size(184, 21);
            this.cb_Programacion.TabIndex = 68;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 59;
            this.label20.Text = "Fecha Menu:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 67;
            this.label24.Text = "Programacion:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 60;
            this.label21.Text = "Alimento:";
            // 
            // dg_Alimento
            // 
            this.dg_Alimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Alimento.Location = new System.Drawing.Point(295, 14);
            this.dg_Alimento.Name = "dg_Alimento";
            this.dg_Alimento.Size = new System.Drawing.Size(358, 112);
            this.dg_Alimento.TabIndex = 66;
            // 
            // cb_Alimento
            // 
            this.cb_Alimento.FormattingEnabled = true;
            this.cb_Alimento.Location = new System.Drawing.Point(94, 39);
            this.cb_Alimento.Name = "cb_Alimento";
            this.cb_Alimento.Size = new System.Drawing.Size(185, 21);
            this.cb_Alimento.TabIndex = 61;
            // 
            // btn_GuardarDetalleServicio
            // 
            this.btn_GuardarDetalleServicio.Location = new System.Drawing.Point(7, 131);
            this.btn_GuardarDetalleServicio.Name = "btn_GuardarDetalleServicio";
            this.btn_GuardarDetalleServicio.Size = new System.Drawing.Size(75, 23);
            this.btn_GuardarDetalleServicio.TabIndex = 65;
            this.btn_GuardarDetalleServicio.Text = "Guardar";
            this.btn_GuardarDetalleServicio.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 62;
            this.label23.Text = "Empleado:";
            // 
            // dg_DetalleServicio
            // 
            this.dg_DetalleServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DetalleServicio.Location = new System.Drawing.Point(7, 160);
            this.dg_DetalleServicio.Name = "dg_DetalleServicio";
            this.dg_DetalleServicio.Size = new System.Drawing.Size(692, 234);
            this.dg_DetalleServicio.TabIndex = 64;
            // 
            // cb_EmpleadoServicio
            // 
            this.cb_EmpleadoServicio.FormattingEnabled = true;
            this.cb_EmpleadoServicio.Location = new System.Drawing.Point(94, 66);
            this.cb_EmpleadoServicio.Name = "cb_EmpleadoServicio";
            this.cb_EmpleadoServicio.Size = new System.Drawing.Size(184, 21);
            this.cb_EmpleadoServicio.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTPFechaMenu);
            this.panel1.Controls.Add(this.cb_Programacion);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.dg_Alimento);
            this.panel1.Controls.Add(this.cb_Alimento);
            this.panel1.Controls.Add(this.btn_GuardarDetalleServicio);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.dg_DetalleServicio);
            this.panel1.Controls.Add(this.cb_EmpleadoServicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 399);
            this.panel1.TabIndex = 70;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 399);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Alimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DetalleServicio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTPFechaMenu;
        private System.Windows.Forms.ComboBox cb_Programacion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dg_Alimento;
        private System.Windows.Forms.ComboBox cb_Alimento;
        private System.Windows.Forms.Button btn_GuardarDetalleServicio;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dg_DetalleServicio;
        private System.Windows.Forms.ComboBox cb_EmpleadoServicio;
        private System.Windows.Forms.Panel panel1;
    }
}