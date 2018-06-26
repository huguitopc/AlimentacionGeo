namespace MG1.Comedor.Presentacion
{
    partial class FrmEmpleado
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
            this.btn_AdicionarCargo = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.cb_NombreCompleto = new System.Windows.Forms.ComboBox();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cb_Area = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_CentroCosto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dg_Empleado = new System.Windows.Forms.DataGridView();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ApPaterno = new System.Windows.Forms.TextBox();
            this.txt_ApMaterno = new System.Windows.Forms.TextBox();
            this.txt_Carnet = new System.Windows.Forms.TextBox();
            this.cb_Sexo = new System.Windows.Forms.ComboBox();
            this.cb_Empresa = new System.Windows.Forms.ComboBox();
            this.cb_Cargo = new System.Windows.Forms.ComboBox();
            this.cb_Turno = new System.Windows.Forms.ComboBox();
            this.dateTPFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dateTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Empleado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AdicionarCargo
            // 
            this.btn_AdicionarCargo.Location = new System.Drawing.Point(601, 37);
            this.btn_AdicionarCargo.Name = "btn_AdicionarCargo";
            this.btn_AdicionarCargo.Size = new System.Drawing.Size(21, 21);
            this.btn_AdicionarCargo.TabIndex = 86;
            this.btn_AdicionarCargo.Text = "+";
            this.btn_AdicionarCargo.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 179);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 13);
            this.label22.TabIndex = 85;
            this.label22.Text = "Nombre Completo";
            // 
            // cb_NombreCompleto
            // 
            this.cb_NombreCompleto.FormattingEnabled = true;
            this.cb_NombreCompleto.Location = new System.Drawing.Point(154, 171);
            this.cb_NombreCompleto.Name = "cb_NombreCompleto";
            this.cb_NombreCompleto.Size = new System.Drawing.Size(200, 21);
            this.cb_NombreCompleto.TabIndex = 84;
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.DisplayMember = "NombreUsuario";
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Location = new System.Drawing.Point(470, 171);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(121, 21);
            this.cb_Usuario.TabIndex = 83;
            this.cb_Usuario.ValueMember = "id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(371, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 82;
            this.label15.Text = "Usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "BUSCAR";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(154, 198);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(200, 20);
            this.txt_Buscar.TabIndex = 80;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(374, 195);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 79;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // cb_Area
            // 
            this.cb_Area.DisplayMember = "NombreArea";
            this.cb_Area.FormattingEnabled = true;
            this.cb_Area.Location = new System.Drawing.Point(470, 118);
            this.cb_Area.Name = "cb_Area";
            this.cb_Area.Size = new System.Drawing.Size(121, 21);
            this.cb_Area.TabIndex = 78;
            this.cb_Area.ValueMember = "Area.id";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(371, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 77;
            this.label13.Text = "Area";
            // 
            // cb_CentroCosto
            // 
            this.cb_CentroCosto.FormattingEnabled = true;
            this.cb_CentroCosto.Location = new System.Drawing.Point(470, 144);
            this.cb_CentroCosto.Name = "cb_CentroCosto";
            this.cb_CentroCosto.Size = new System.Drawing.Size(121, 21);
            this.cb_CentroCosto.TabIndex = 76;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(371, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Centro de Costo";
            // 
            // dg_Empleado
            // 
            this.dg_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Empleado.Location = new System.Drawing.Point(22, 224);
            this.dg_Empleado.Name = "dg_Empleado";
            this.dg_Empleado.Size = new System.Drawing.Size(619, 163);
            this.dg_Empleado.TabIndex = 74;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(154, 12);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(123, 20);
            this.txt_Nombre.TabIndex = 73;
            // 
            // txt_ApPaterno
            // 
            this.txt_ApPaterno.Location = new System.Drawing.Point(154, 38);
            this.txt_ApPaterno.Name = "txt_ApPaterno";
            this.txt_ApPaterno.Size = new System.Drawing.Size(123, 20);
            this.txt_ApPaterno.TabIndex = 72;
            // 
            // txt_ApMaterno
            // 
            this.txt_ApMaterno.Location = new System.Drawing.Point(154, 64);
            this.txt_ApMaterno.Name = "txt_ApMaterno";
            this.txt_ApMaterno.Size = new System.Drawing.Size(123, 20);
            this.txt_ApMaterno.TabIndex = 71;
            // 
            // txt_Carnet
            // 
            this.txt_Carnet.Location = new System.Drawing.Point(154, 145);
            this.txt_Carnet.Name = "txt_Carnet";
            this.txt_Carnet.Size = new System.Drawing.Size(123, 20);
            this.txt_Carnet.TabIndex = 70;
            // 
            // cb_Sexo
            // 
            this.cb_Sexo.FormattingEnabled = true;
            this.cb_Sexo.Location = new System.Drawing.Point(154, 90);
            this.cb_Sexo.Name = "cb_Sexo";
            this.cb_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_Sexo.TabIndex = 69;
            // 
            // cb_Empresa
            // 
            this.cb_Empresa.DisplayMember = "RazonSocial";
            this.cb_Empresa.FormattingEnabled = true;
            this.cb_Empresa.Location = new System.Drawing.Point(470, 11);
            this.cb_Empresa.Name = "cb_Empresa";
            this.cb_Empresa.Size = new System.Drawing.Size(121, 21);
            this.cb_Empresa.TabIndex = 68;
            this.cb_Empresa.ValueMember = "id";
            // 
            // cb_Cargo
            // 
            this.cb_Cargo.DisplayMember = "NombreCargo";
            this.cb_Cargo.FormattingEnabled = true;
            this.cb_Cargo.Location = new System.Drawing.Point(470, 37);
            this.cb_Cargo.Name = "cb_Cargo";
            this.cb_Cargo.Size = new System.Drawing.Size(121, 21);
            this.cb_Cargo.TabIndex = 67;
            this.cb_Cargo.ValueMember = "id";
            // 
            // cb_Turno
            // 
            this.cb_Turno.DisplayMember = "NombreTurno";
            this.cb_Turno.FormattingEnabled = true;
            this.cb_Turno.Location = new System.Drawing.Point(470, 88);
            this.cb_Turno.Name = "cb_Turno";
            this.cb_Turno.Size = new System.Drawing.Size(121, 21);
            this.cb_Turno.TabIndex = 66;
            this.cb_Turno.ValueMember = "id";
            // 
            // dateTPFechaIngreso
            // 
            this.dateTPFechaIngreso.Location = new System.Drawing.Point(470, 64);
            this.dateTPFechaIngreso.Name = "dateTPFechaIngreso";
            this.dateTPFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dateTPFechaIngreso.TabIndex = 65;
            // 
            // dateTPFechaNac
            // 
            this.dateTPFechaNac.Location = new System.Drawing.Point(154, 119);
            this.dateTPFechaNac.Name = "dateTPFechaNac";
            this.dateTPFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dateTPFechaNac.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Turno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Fecha de Ingreso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Cargo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Documento de Identidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombre(s)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_AdicionarCargo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_NombreCompleto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_Usuario);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_Buscar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cb_Area);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dateTPFechaNac);
            this.panel1.Controls.Add(this.cb_CentroCosto);
            this.panel1.Controls.Add(this.dateTPFechaIngreso);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cb_Turno);
            this.panel1.Controls.Add(this.dg_Empleado);
            this.panel1.Controls.Add(this.cb_Cargo);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Controls.Add(this.cb_Empresa);
            this.panel1.Controls.Add(this.txt_ApPaterno);
            this.panel1.Controls.Add(this.cb_Sexo);
            this.panel1.Controls.Add(this.txt_ApMaterno);
            this.panel1.Controls.Add(this.txt_Carnet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 399);
            this.panel1.TabIndex = 87;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 399);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpleado";
            this.Text = "FrmEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Empleado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AdicionarCargo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cb_NombreCompleto;
        private System.Windows.Forms.ComboBox cb_Usuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ComboBox cb_Area;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_CentroCosto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dg_Empleado;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_ApPaterno;
        private System.Windows.Forms.TextBox txt_ApMaterno;
        private System.Windows.Forms.TextBox txt_Carnet;
        private System.Windows.Forms.ComboBox cb_Sexo;
        private System.Windows.Forms.ComboBox cb_Empresa;
        private System.Windows.Forms.ComboBox cb_Cargo;
        private System.Windows.Forms.ComboBox cb_Turno;
        private System.Windows.Forms.DateTimePicker dateTPFechaIngreso;
        private System.Windows.Forms.DateTimePicker dateTPFechaNac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}