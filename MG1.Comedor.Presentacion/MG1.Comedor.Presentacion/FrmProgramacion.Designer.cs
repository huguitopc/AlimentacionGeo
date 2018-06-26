namespace MG1.Comedor.Presentacion
{
    partial class FrmProgramacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_EmpleadoProgramacion = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label25 = new System.Windows.Forms.Label();
            this.cb_CCostoProgramacion = new System.Windows.Forms.ComboBox();
            this.txt_BuscarEmpleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_AreaProgramacion = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_Empleado = new System.Windows.Forms.ComboBox();
            this.btn_GuardarProgramacion = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dateTPProgA = new System.Windows.Forms.DateTimePicker();
            this.dateTPProgDe = new System.Windows.Forms.DateTimePicker();
            this.dg_DetalleProgramacion = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_EmpleadoProgramacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DetalleProgramacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg_EmpleadoProgramacion);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.cb_CCostoProgramacion);
            this.panel1.Controls.Add(this.txt_BuscarEmpleado);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cb_AreaProgramacion);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cb_Empleado);
            this.panel1.Controls.Add(this.btn_GuardarProgramacion);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.dateTPProgA);
            this.panel1.Controls.Add(this.dateTPProgDe);
            this.panel1.Controls.Add(this.dg_DetalleProgramacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 399);
            this.panel1.TabIndex = 69;
            // 
            // dg_EmpleadoProgramacion
            // 
            this.dg_EmpleadoProgramacion.AllowUserToAddRows = false;
            this.dg_EmpleadoProgramacion.AllowUserToDeleteRows = false;
            this.dg_EmpleadoProgramacion.AllowUserToOrderColumns = true;
            this.dg_EmpleadoProgramacion.AllowUserToResizeColumns = false;
            this.dg_EmpleadoProgramacion.AllowUserToResizeRows = false;
            this.dg_EmpleadoProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_EmpleadoProgramacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dg_EmpleadoProgramacion.Location = new System.Drawing.Point(12, 140);
            this.dg_EmpleadoProgramacion.Name = "dg_EmpleadoProgramacion";
            this.dg_EmpleadoProgramacion.Size = new System.Drawing.Size(277, 247);
            this.dg_EmpleadoProgramacion.TabIndex = 41;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Programar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(16, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 13);
            this.label25.TabIndex = 40;
            this.label25.Text = "Centro Costo:";
            // 
            // cb_CCostoProgramacion
            // 
            this.cb_CCostoProgramacion.FormattingEnabled = true;
            this.cb_CCostoProgramacion.Location = new System.Drawing.Point(87, 46);
            this.cb_CCostoProgramacion.Name = "cb_CCostoProgramacion";
            this.cb_CCostoProgramacion.Size = new System.Drawing.Size(158, 21);
            this.cb_CCostoProgramacion.TabIndex = 39;
            // 
            // txt_BuscarEmpleado
            // 
            this.txt_BuscarEmpleado.Location = new System.Drawing.Point(87, 112);
            this.txt_BuscarEmpleado.Name = "txt_BuscarEmpleado";
            this.txt_BuscarEmpleado.Size = new System.Drawing.Size(158, 20);
            this.txt_BuscarEmpleado.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Empleado:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Area:";
            // 
            // cb_AreaProgramacion
            // 
            this.cb_AreaProgramacion.FormattingEnabled = true;
            this.cb_AreaProgramacion.Location = new System.Drawing.Point(87, 18);
            this.cb_AreaProgramacion.Name = "cb_AreaProgramacion";
            this.cb_AreaProgramacion.Size = new System.Drawing.Size(158, 21);
            this.cb_AreaProgramacion.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Buscar:";
            // 
            // cb_Empleado
            // 
            this.cb_Empleado.FormattingEnabled = true;
            this.cb_Empleado.Location = new System.Drawing.Point(87, 79);
            this.cb_Empleado.Name = "cb_Empleado";
            this.cb_Empleado.Size = new System.Drawing.Size(201, 21);
            this.cb_Empleado.TabIndex = 33;
            // 
            // btn_GuardarProgramacion
            // 
            this.btn_GuardarProgramacion.Location = new System.Drawing.Point(595, 23);
            this.btn_GuardarProgramacion.Name = "btn_GuardarProgramacion";
            this.btn_GuardarProgramacion.Size = new System.Drawing.Size(75, 23);
            this.btn_GuardarProgramacion.TabIndex = 32;
            this.btn_GuardarProgramacion.Text = "Guardar";
            this.btn_GuardarProgramacion.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(327, 54);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "A:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(326, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "De:";
            // 
            // dateTPProgA
            // 
            this.dateTPProgA.Location = new System.Drawing.Point(390, 49);
            this.dateTPProgA.Name = "dateTPProgA";
            this.dateTPProgA.Size = new System.Drawing.Size(200, 20);
            this.dateTPProgA.TabIndex = 29;
            // 
            // dateTPProgDe
            // 
            this.dateTPProgDe.Location = new System.Drawing.Point(390, 22);
            this.dateTPProgDe.Name = "dateTPProgDe";
            this.dateTPProgDe.Size = new System.Drawing.Size(200, 20);
            this.dateTPProgDe.TabIndex = 28;
            // 
            // dg_DetalleProgramacion
            // 
            this.dg_DetalleProgramacion.AllowUserToAddRows = false;
            this.dg_DetalleProgramacion.AllowUserToDeleteRows = false;
            this.dg_DetalleProgramacion.AllowUserToOrderColumns = true;
            this.dg_DetalleProgramacion.AllowUserToResizeColumns = false;
            this.dg_DetalleProgramacion.AllowUserToResizeRows = false;
            this.dg_DetalleProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DetalleProgramacion.Location = new System.Drawing.Point(295, 140);
            this.dg_DetalleProgramacion.Name = "dg_DetalleProgramacion";
            this.dg_DetalleProgramacion.Size = new System.Drawing.Size(410, 247);
            this.dg_DetalleProgramacion.TabIndex = 27;
            // 
            // FrmProgramacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 399);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProgramacion";
            this.Text = "FrmProgramacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_EmpleadoProgramacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DetalleProgramacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dg_EmpleadoProgramacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cb_CCostoProgramacion;
        private System.Windows.Forms.TextBox txt_BuscarEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_AreaProgramacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_Empleado;
        private System.Windows.Forms.Button btn_GuardarProgramacion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dateTPProgA;
        private System.Windows.Forms.DateTimePicker dateTPProgDe;
        private System.Windows.Forms.DataGridView dg_DetalleProgramacion;
    }
}